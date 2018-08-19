using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double In_to_Cm= 2.51 * 2.51;
        static string result;
        static double cac_result;
        static string data1;
        static string data2;
        private void 使用指南ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本工具为通用面积计算器，请选择几何形状和输入单位，最后的结果输出以平方厘米为单位。");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作者：向朝阳，张俊，彭圣钧，彭杰科，肖凯\n联系邮箱：979915781@qq.com");
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square
            {
                Side = Convert.ToDouble(txtSide.Text)
            };
            if (square.Side <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else
            {
                if (btnCm.Checked)
                    cac_result = square.Area;
                else if (btnIn.Checked)
                {
                    cac_result = square.Area * In_to_Cm;
                    square.Side = square.Side * 2.51;
                }
                result = cac_result.ToString("#0.000");
                data1 = square.Side.ToString("#0.000");
                MessageBox.Show("您选择的是正方形"+"\n"+"您输入的边长为："+data1+"厘米"+"\n"+"该正方形的面积是" + result + "平方厘米");
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle
            {
                Length = Convert.ToDouble(txtLength.Text),
                Width = Convert.ToDouble(txtWidth.Text)
            };
            if (rectangle.Length <= 0 || rectangle.Width <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else if (btnIn.Checked)
            {
                cac_result = rectangle.Area * In_to_Cm;
                rectangle.Length = rectangle.Length * 2.51;
                rectangle.Width = rectangle.Width * 2.51;
            }
            else if (btnCm.Checked)
                cac_result = rectangle.Area;
            result = cac_result.ToString("#0.000");
            data1= rectangle.Length.ToString("#0.000");
            data2 = rectangle.Width.ToString("#0.000");
            MessageBox.Show("您选择的是长方形"+"\n" + "您输入的长为：" + data1 + "厘米"+"\n" + "宽为" +data2+"厘米"+ "\n" + "该正方形的面积是" + result + "平方厘米");
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle
            {
                Base_side = Convert.ToDouble(txtBase_side.Text),
                Height = Convert.ToDouble(txtHeight.Text)
            };
            if (triangle.Height <= 0 || triangle.Base_side <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else if (btnIn.Checked)
            {
                cac_result = triangle.Area * In_to_Cm;
                triangle.Base_side = triangle.Base_side * 2.51;
                triangle.Height = triangle.Height * 2.51;
            }
            else if (btnCm.Checked)
                cac_result = triangle.Area;
            result = cac_result.ToString("#0.000");
            data1 = triangle.Base_side.ToString("#0.000");
            data2 = triangle.Height.ToString("#0.000");
            MessageBox.Show("您选择的是三角形"+ "\n" + "您输入的底为：" + data1 + "厘米" + "\n" + "高为" + data2 + "厘米" + "\n" + "该三角形的面积是" + result + "平方厘米");

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle
            {
                Diameter = Convert.ToDouble(txtDiameter.Text)
            };
            if (circle.Diameter <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else if (btnIn.Checked)
            {
                cac_result = circle.Area * In_to_Cm;
                circle.Diameter = circle.Diameter * 2.51;
            }
            else if (btnCm.Checked)
                cac_result = circle.Area;
            result = cac_result.ToString("#0.000");
            data1 = circle.Diameter.ToString("#0.000");
            MessageBox.Show("您选择的是圆形"+"\n"+"您输入的直径为：" + data1 + "厘米" + "\n" + "该圆形的面积是" + result + "平方厘米");
        }
    }
    }


