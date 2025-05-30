using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing.Printing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using System.Net;

namespace IOT_BT1B
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort(); // khai bao serialPort1
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();


        }
        byte[] tx_buffet = new byte[1];
        byte[] rx_buffet = new byte[1];
        byte SlaveID;
        ushort Address;
        ushort numReg;
        byte Function;
        int byteRead;
        int bytesRead;
        byte[] response;
        byte[] request;
        int Read_button_RTU = 0;
        int Read_button_Controller = 0;
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);// add cac cong come
        }
        public static class Seding_receivering //tạo biến toàn cục
        {
            public static string data = "";
            public static byte[] Rx_DV1 = new byte[20];
            public static byte[] Tx_DV1 = new byte[20];
        }
        void signal_digital(byte[] buffet)
        {
            if ((buffet[0] & (0x01 << 0)) == (0x01 << 0)) //RUN
            {
                button5.BackColor = Color.Red; 
            }
            else
            {
                button5.BackColor = Color.White;
            }
            if ((buffet[0] & (0x01 << 1)) == (0x01 << 1)) //STOP
            {
                button6.BackColor = Color.Yellow;
            }
            else
            {
                button6.BackColor = Color.White;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // OPEN
        {
            try
            {

                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.Open();
                progressBar1.Value = 100;
                button1.Enabled = false; //open
                button2.Enabled = true; //close
                button3.Enabled = true; //send
                button4.Enabled = true; //read
                button7.Enabled = true; //onK1
                button8.Enabled = true; //offK1
                button9.Enabled = true; //onK2
                button10.Enabled = true; //offK2
                button11.Enabled = true; //onK3
                button12.Enabled = true; //offK3
                button13.Enabled = true; //Modbus
                button14.Enabled = true;
                button15.Enabled = true;
                //clear

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Receiving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e) //CLOSE
        {
            serialPort1.Close();
            timer1.Enabled = false;
            progressBar1.Value = 0;
            button1.Enabled = true; //open
            button2.Enabled = false; //close
            button3.Enabled = false; //send
            button4.Enabled = false; //read
            button7.Enabled = false; //onK1
            button8.Enabled = false; //offK1
            button9.Enabled = false; ///onK2
            button10.Enabled = false; //offK2
            button11.Enabled = false; //onK3
            button12.Enabled = false; //offK3
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            timer1.Enabled=false;

        }
        //lấy dữ liệu của các thanh ghi

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (Read_button_Controller == 1)
                    {
                        // Nhận dữ liệu
                        if (serialPort1.BytesToRead > 0)
                        {
                            int numBytesToRead = serialPort1.BytesToRead;
                            serialPort1.Read(rx_buffet, 0, Math.Min(rx_buffet.Length, numBytesToRead));

                            signal_digital(rx_buffet);
                            textBox2.Text = rx_buffet[0].ToString();


                        }

                        //// Gửi dữ liệu
                        if (tx_buffet.Length > 0)
                        {
                            serialPort1.Write(tx_buffet, 0, 1);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gửi/nhận dữ liệu: {ex.Message}", "Serial Port Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    if (Read_button_RTU == 1)
                    {
                        //SlaveID = byte.Parse(textBox3.Text);
                        //Address = ushort.Parse(textBox4.Text);
                        //numReg = ushort.Parse(textBox5.Text);
                        if (!ushort.TryParse(textBox5.Text, out numReg) || numReg == 0)
                        {
                            return;
                        }
                        if (!ushort.TryParse(textBox4.Text, out Address))
                        {
                            return;
                        }
                        if (!byte.TryParse(textBox3.Text, out SlaveID) || SlaveID == 0)
                        {
                            return;
                        }

                        Function = (comboBox3.Text == "03 Read") ? (byte)3 : (byte)16;
                        //FC03
                        if (Function == 3)
                        {
                            
                            ushort numReg = 2; // Đọc 1 thanh ghi duy nhất

                            request = CreateModbusRequestFC03(SlaveID, Function, Address, numReg);

                            await Task.Run(() => serialPort1.Write(request, 0, request.Length));
                            textBox6.AppendText("Send request: " + BitConverter.ToString(request) + "\r\n");

                            await Task.Delay(200); // Đợi slave trả lời

                            response = new byte[5 + numReg * 2]; // Slave ID + Function + Byte Count + Data + CRC
                            bytesRead = await Task.Run(() => serialPort1.Read(response, 0, response.Length));

                            if (bytesRead > 0)
                            {
                                textBox6.AppendText("Response to Slave: " + BitConverter.ToString(response) + "\r\n");

                                if (ValidateCRC(response))
                                {
                                    textBox7.Clear();
                                    for(int i = 0; i< numReg; i++)
                                    {
                                        ushort value = (ushort)((response[3 + (i * 2)] << 8) | response[4 + (i * 2)]);
                                        textBox7.AppendText($"Reg{i}: {value}\r\n");
                                        byte dataLow = response[6]; // response[3] là High, response[4] là Low
                                        rx_buffet[0] = dataLow; // Gán vào buffer xử lý
                                        signal_digital(rx_buffet); //
                                    }
                                    
                                }
                                else
                                {
                                    textBox6.AppendText("Error: CRC\r\n");
                                }
                            }
                            else
                            {
                                textBox6.AppendText("Response Error: No data received from slave.\r\n");
                            }
                        }
                        //FC10 write
                        if (Function == 16)
                        {
                            textBox12.Text = tx_buffet[0].ToString();
                            //byte temp1 = Convert.ToByte(textBox5.Text);
                            //byte temp2 = Convert.ToByte(textBox4.Text);
                            //int temp3 = ((temp2 - temp1) + 1);
                            //textBox11.AppendText((Convert.ToString(temp3)));
                            if (!ushort.TryParse(textBox11.Text, out Address))
                            {
                                textBox6.AppendText("Registers name error\r\n");
                                return;
                            }

                            if (!ushort.TryParse(textBox12.Text, out ushort valueToWrite))
                            {
                                textBox6.AppendText("Ship data error\r\n");
                                return;
                            }

                            ushort[] registerValues = new ushort[] { valueToWrite };

                            request = CreateModbusRequestFC16(SlaveID, Address, registerValues);
                            await Task.Run(() => serialPort1.Write(request, 0, request.Length));
                            textBox6.AppendText("Send FC16: " + BitConverter.ToString(request) + "\r\n");

                            await Task.Delay(100); // Cho slave xử lý

                            byte[] response = new byte[8];
                            int bytesRead = await Task.Run(() => serialPort1.Read(response, 0, response.Length));

                            if (bytesRead < 8)
                            {
                                textBox6.AppendText($"Lỗi: Phản hồi không đủ byte. Nhận được {bytesRead}\r\n");
                                return;
                            }

                            if (!ValidateCRC(response))
                            {
                                textBox6.AppendText("Lỗi: CRC phản hồi không hợp lệ\r\n");
                                return;
                            }

                            textBox6.AppendText("Response: " + BitConverter.ToString(response) + "\r\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi giao tiếp Modbus: " + ex.Message);
                }
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            //K1On
            tx_buffet[0] |= (0x01 << 0);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //K1Off
            tx_buffet[0] = (byte)(tx_buffet[0] & ~(0x01 << 0));

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //K2On
            tx_buffet[0] |= (0x01 << 1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //K2Off
            tx_buffet[0] = (byte)(tx_buffet[0] & ~(0x01 << 1));

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //K3On
            tx_buffet[0] |= (0x01 << 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //K3Off
            tx_buffet[0] = (byte)(tx_buffet[0] & ~(0x01 << 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
        private ushort ComputeCRC(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (int i = 0; i < data.Length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                        crc = (ushort)((crc >> 1) ^ 0xA001);
                    else
                        crc >>= 1;
                }
            }
            return crc;
        }
        private bool ValidateCRC(byte[] response)
        {
            if (response.Length < 2) return false;

            ushort receivedCRC = (ushort)((response[response.Length - 1] << 8) | response[response.Length - 2]);
            ushort calculatedCRC = ComputeCRC(response.Take(response.Length - 2).ToArray());

            return receivedCRC == calculatedCRC;
        }
        private byte[] CreateModbusRequestFC03(byte slaveID, byte Funcition, ushort startAddress, ushort numReg)
        {
            byte[] request = new byte[8]; // +thêm CRC 2byte = 8 byte
            request[0] = slaveID;
            request[1] = Funcition;
            request[2] = (byte)(startAddress >> 8);
            request[3] = (byte)(startAddress & 0xFF);
            request[4] = (byte)(numReg >> 8);
            request[5] = (byte)(numReg & 0xFF);

            // Tính CRC cho yêu cầu (trừ CRC)
            ushort crc = ComputeCRC(request.Take(6).ToArray());

            // Thêm CRC vào yêu cầu
            request[6] = (byte)(crc & 0xFF);        // CRC low byte
            request[7] = (byte)((crc >> 8) & 0xFF); // CRC high byte
            return request;

        }

        //FC16
        byte[] CreateModbusRequestFC16(byte slaveID, ushort startAddress, ushort[] values)
        {
            List<byte> frame = new List<byte>();

            frame.Add(slaveID);               // Slave ID
            frame.Add(0x10);                  // Function code 16
            frame.Add((byte)(startAddress >> 8)); // Start address Hi
            frame.Add((byte)(startAddress & 0xFF)); // Start address Lo
            frame.Add((byte)(values.Length >> 8));  // Quantity Hi
            frame.Add((byte)(values.Length & 0xFF)); // Quantity Lo
            frame.Add((byte)(values.Length * 2));    // Byte count
            // Add register values (each is 2 bytes)
            foreach (ushort val in values)
            {
                frame.Add((byte)(val >> 8));   // High byte
                frame.Add((byte)(val & 0xFF)); // Low byte
            }

            // Tính CRC
            ushort crc = ComputeCRC(frame.ToArray());
            frame.Add((byte)(crc & 0xFF));   // CRC Low
            frame.Add((byte)(crc >> 8));     // CRC High

            return frame.ToArray();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Read_button_RTU = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Read_button_Controller = 1;
        }
    }

}
