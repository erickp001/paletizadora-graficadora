using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using usbGenericHidCommunications;
using System.Threading.Tasks;

namespace PaletizadoraV1._0
{
    public partial class USBcontrol : usbGenericHidCommunication
    {
        public USBcontrol(int vid, int pid) : base(vid, pid)
        { }

        public string CollectDebug()
        {
            Byte[] outputBuffer = new Byte[65];
            Byte[] inputBuffer = new Byte[65];

            outputBuffer[0] = 0x0;
            outputBuffer[1] = 0x10;

            writeRawReportToDevice(outputBuffer);
            readSingleReportFromDevice(ref inputBuffer);

            if (inputBuffer[1] == 0 || inputBuffer[1] == 255) return String.Empty;

            string s = System.Text.ASCIIEncoding.ASCII.GetString(inputBuffer, 2, inputBuffer[1]);

            return s;
        }
        public bool SendASCII(string strOutputBuffer)
        {
            Byte[] outputBuffer = new Byte[65];

            outputBuffer[0] = 0;
            outputBuffer[1] = 0x11;

            byte[] bytesToSendBuffer = Encoding.ASCII.GetBytes(strOutputBuffer);

            for (int i = 2; i < outputBuffer.Length; i++)
            {
                if (i < bytesToSendBuffer.Length + 2)
                    outputBuffer[i] = bytesToSendBuffer[i - 2];
                else
                    //outputBuffer[i] = 0;
                    break;
            }

            bool success = writeRawReportToDevice(outputBuffer);

            return success;
        }

        public bool MotorDualMove (byte signo1,
                              byte stepsMotor1HighByte, byte stepsMotor1LowByte,
                              byte signo2,
                              byte stepsMotor2HighByte, byte stepsMotor2LowByte)
        {
            Byte[] outputBuffer = new Byte[65];
            outputBuffer[0] = 0;
            outputBuffer[1] = 0x50;
            outputBuffer[2] = signo1;
            outputBuffer[3] = stepsMotor1HighByte;
            outputBuffer[4] = stepsMotor1LowByte;
            outputBuffer[5] = signo2;
            outputBuffer[6] = stepsMotor2HighByte;
            outputBuffer[7] = stepsMotor2LowByte;
            bool success;
            success = writeRawReportToDevice(outputBuffer);
            return success;
        }

        public bool Motor1Move(byte signo1,
                             byte stepsMotor1HighByte, byte stepsMotor1LowByte)
        {
            Byte[] outputBuffer = new Byte[65];
            outputBuffer[0] = 0;    
            outputBuffer[1] = 0x60;
            outputBuffer[2] = signo1;
            outputBuffer[3] = stepsMotor1HighByte;
            outputBuffer[4] = stepsMotor1LowByte;
            bool success;
            success = writeRawReportToDevice(outputBuffer);
            return success;
        }
        public bool Motor2Move(byte signo2,
                             byte stepsMotor2HighByte, byte stepsMotor2LowByte)
        {
            Byte[] outputBuffer = new Byte[65];
            outputBuffer[0] = 0;
            outputBuffer[1] = 0x70;
            outputBuffer[5] = signo2;
            outputBuffer[6] = stepsMotor2HighByte;
            outputBuffer[7] = stepsMotor2LowByte;
            bool success;
            success = writeRawReportToDevice(outputBuffer);
            return success;
        }

        public Byte Lector()
        {
            Byte[] outputBuffer = new Byte[65];
            Byte[] inputBuffer = new Byte[65];

            outputBuffer[0] = 0x0;
            outputBuffer[1] = 0x13;

            writeRawReportToDevice(outputBuffer);
            readSingleReportFromDevice(ref inputBuffer);

            if (inputBuffer[1] == 0 || inputBuffer[1] == 255)
                return 0;
            return inputBuffer[2];
        }
    }
}

