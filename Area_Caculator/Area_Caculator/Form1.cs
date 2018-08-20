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
    { /*
        *程序说明：
        * 此程序为面积计算器
        * 用户可自主选择所计算几何图形的形状和输入单位
        * 形状支持正方形，长方形，三角形和圆形，单位支持厘米和英寸
        * 输出的默认单位为厘米和平方厘米
        * 制作者：向朝阳，张俊，彭胜钧，肖凯，彭杰科
        */
        public Form1()
        {
            InitializeComponent();
        }
    
        const double In_to_Cm= 2.51;//厘米到英寸的转换常量
        static string string_cac_result;//面积计算结果的字符串形式
        static double double_cac_result;//面积计算结果的双精度浮点数形式
        static string txtInput1;//文本框1的输入数据
        static string txtInput2;//文本框2的输入数据
        private void 使用指南ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本工具为通用面积计算器，请选择几何形状和输入单位，最后的结果输出以平方厘米为单位。");//帮助信息
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作者：向朝阳，张俊，彭圣钧，彭杰科，肖凯\n联系邮箱：979915781@qq.com");//关于信息
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square
            {
                Side = Convert.ToDouble(txtSide.Text)//边长输入数据的类型转换
            };
            if (square.Side <= 0)
                MessageBox.Show("输入错误，请重新输入！");//输入数据不能小于等于0
            else
            {
                if (rdoCm.Checked)
                    double_cac_result = square.Area;//单位选择的判断和处理
                else if (rdoIn.Checked)
                {
                    double_cac_result = square.Area * In_to_Cm* In_to_Cm;
                    square.Side = square.Side * In_to_Cm;
                }
                string_cac_result = double_cac_result.ToString("#0.000");//计算结果的处理
                txtInput1 = square.Side.ToString("#0.000");
                MessageBox.Show("您选择的是正方形"+"\n"+"您输入的边长为："+ txtInput1 + "厘米"+"\n"+"该正方形的面积是" + string_cac_result + "平方厘米");//输入数据和计算结果的输出
            }
        }
        //之后的程序注释注释主体与上述相同
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle
            {
                Length = Convert.ToDouble(txtLength.Text),
                Width = Convert.ToDouble(txtWidth.Text)
            };
            if (rectangle.Length <= 0 || rectangle.Width <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else if (rdoIn.Checked)
            {
                double_cac_result = rectangle.Area * In_to_Cm* In_to_Cm;
                rectangle.Length = rectangle.Length * In_to_Cm;
                rectangle.Width = rectangle.Width * In_to_Cm;
            }
            else if (rdoCm.Checked)
                double_cac_result = rectangle.Area;
            string_cac_result = double_cac_result.ToString("#0.000");
            txtInput1 = rectangle.Length.ToString("#0.000");
            txtInput2 = rectangle.Width.ToString("#0.000");
            MessageBox.Show("您选择的是长方形"+"\n" + "您输入的长为：" + txtInput1 + "厘米"+"\n" + "宽为" +txtInput2+"厘米"+ "\n" + "该正方形的面积是" + string_cac_result + "平方厘米");
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
            else if (rdoIn.Checked)
            {
                double_cac_result = triangle.Area * In_to_Cm* In_to_Cm;
                triangle.Base_side = triangle.Base_side * In_to_Cm;
                triangle.Height = triangle.Height * In_to_Cm;
            }
            else if (rdoCm.Checked)
                double_cac_result = triangle.Area;
            string_cac_result = double_cac_result.ToString("#0.000");
            txtInput1 = triangle.Base_side.ToString("#0.000");
            txtInput2 = triangle.Height.ToString("#0.000");
            MessageBox.Show("您选择的是三角形"+ "\n" + "您输入的底为：" + txtInput1 + "厘米" + "\n" + "高为" + txtInput2 + "厘米" + "\n" + "该三角形的面积是" + string_cac_result + "平方厘米");

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle
            {
                Diameter = Convert.ToDouble(txtDiameter.Text)
            };
            if (circle.Diameter <= 0)
                MessageBox.Show("输入错误，请重新输入！");
            else if (rdoIn.Checked)
            {
                double_cac_result = circle.Area * In_to_Cm* In_to_Cm;
                circle.Diameter = circle.Diameter * In_to_Cm;
            }
            else if (rdoCm.Checked)
                double_cac_result = circle.Area;
            string_cac_result = double_cac_result.ToString("#0.000");
            txtInput1 = circle.Diameter.ToString("#0.000");
            MessageBox.Show("您选择的是圆形"+"\n"+"您输入的直径为：" + txtInput1 + "厘米" + "\n" + "该圆形的面积是" + string_cac_result + "平方厘米");
        }
    }
    }


