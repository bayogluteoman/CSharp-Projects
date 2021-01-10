using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateAgentRegistration
{
    public partial class ImagePopupForm : Form
    {
        public ImagePopupForm()
        {
            InitializeComponent();
        }

        private void ImagePopupForm_Load(object sender, EventArgs e)
        {
            Image img1 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image1.jpg");
            Image img2 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image2.jpg");
            Image img3 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image3.jpg");
            Image img4 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image4.jpg");
            Image img5 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image5.jpg");
            Image img6 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image6.jpg");
            Image img7 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image7.jpg");
            Image img8 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image8.jpg");
            Image img9 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image9.jpg");
            Image img10 = Image.FromFile("D:\\CENG-3\\Advanced Programming Techniques\\RealEstateAgentRegistration\\RealEstateAgentRegistration\\images\\image10.jpg");

            List<Image> images = new List<Image>();
           
            images.Add(img1);
            images.Add(img2);
            images.Add(img3);
            images.Add(img4);
            images.Add(img5);
            images.Add(img6);
            images.Add(img7);
            images.Add(img8);
            images.Add(img9);
            images.Add(img10);

            Random rnd = new Random();
            int rand = rnd.Next(images.Count);
            pictureBox1.Image = images[rand];

        }
    }
}
