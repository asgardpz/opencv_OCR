using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Tesseract;
using OpenCvSharp;


namespace opencv_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_ocr_Click(object sender, EventArgs e)
        {
            var ocrengine = new TesseractEngine(@"tessdata", "eng", EngineMode.Default);

            PageSegMode pSegMode = PageSegMode.AutoOnly;

            if (comboBox_camera_list.SelectedItem == "USB Webcam")
            {
                take_picture_switch = true;
                var img = Pix.LoadFromFile("ocr_img.png");
                var res = ocrengine.Process(img, pSegMode);
                label_output_text.Text = res.GetText();
            }
            else
            {
                var img = Pix.LoadFromFile(@"OCR_test_IMG.jpg");
                var res = ocrengine.Process(img, pSegMode);
                label_output_text.Text = res.GetText();
            }

        }

        bool camera_switch = false;
        bool take_picture_switch = false;
        private void comboBox_camera_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_camera_list.SelectedItem == "USB Webcam")
            {
                camera_switch = true;
                Console.WriteLine(comboBox_camera_list.SelectedText);
                FrameSource frame = Cv2.CreateFrameSource_Camera(0);
                

                Mat mat_image = new Mat();
                while (true)
                {
                    frame.NextFrame(mat_image); 
                    this.pictureBox_image.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat_image);
                    Cv2.WaitKey();
                    if(take_picture_switch == true)
                    {
                        Cv2.ImWrite("ocr_img.png", mat_image);
                    }
                    take_picture_switch = false;


                    if (camera_switch == false)
                    {
                        break;
                    }
                }
                mat_image.Release();
                Cv2.DestroyAllWindows();

            }
            else
            {
                camera_switch = false;
                pictureBox_image.Image = Image.FromFile(@"OCR_test_IMG.jpg");
            }
        }
    }
}
