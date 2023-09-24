using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private double currentAngle = 0.0; // 存储当前旋转角度
        private double addCurrentAngle = 90.0; // 每次增加的旋轉角度

        bool lottery_toggle = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void lottery_btn_Click(object sender, EventArgs e)
        {
            //方法一: 固定角度
            //// 生成随机角度以模拟旋转
            //double randomAngle = random.NextDouble() * 360;

            //// 使用 System.Threading.Thread.Sleep() 创建旋转动画效果（可选）
            //for (int i = 0; i < 36; i++)
            //{
            //    roulettePictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //    roulettePictureBox.Refresh();
            //    System.Threading.Thread.Sleep(50);
            //}

            //// 最终停在随机角度
            //roulettePictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //roulettePictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            //roulettePictureBox.Refresh();


            //方法二: 自訂旋轉角度
            lottery_toggle = !lottery_toggle;
            //timer1.Enabled = lottery_toggle;
            // 旋转图像
            //for (int i = 0; i < 36; i++)
            //{
            //    RotateImage(currentAngle);
            //    roulettePictureBox.Refresh();
            //    System.Threading.Thread.Sleep(50);
            //}

            //if (lottery_toggle)
            //{
            //    currentAngle += addCurrentAngle;
            //    // 旋转图像
            //    RotateImage(currentAngle);
            //    roulettePictureBox.Refresh();
            //    System.Threading.Thread.Sleep(50);
            //}

            //sping();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 设置转盘图片
            //roulettePictureBox.Image = Properties.Resources.roulette_wheel;

            // 调整图片大小以适应窗体
            roulettePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // 自定义旋转图像的方法
        private void RotateImage(double angle)
        {
            //if (roulettePictureBox.Image != null)
            //{          
            //}
            // 创建一个副本以防止修改原始图像
            Image rotatedImage = (Image)roulettePictureBox.Image.Clone();

            // 创建旋转变换
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2);
                g.RotateTransform((float)angle);
                g.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2);
                g.DrawImage(roulettePictureBox.Image, Point.Empty);
            }

            // 更新 PictureBox 中的图像
            roulettePictureBox.Image = rotatedImage;
        }

        private void sping() {
            currentAngle += addCurrentAngle;
            // 旋转图像
            RotateImage(currentAngle);
            roulettePictureBox.Refresh();
            System.Threading.Thread.Sleep(50);

            if (lottery_toggle)
            {
                sping();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lottery_toggle) {
                currentAngle += addCurrentAngle;
                // 旋转图像
                RotateImage(currentAngle);
                roulettePictureBox.Refresh();
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
