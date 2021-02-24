using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Graphics g;

        //Значения из полей ввода для линии
        private int x1LineInput;
        private int y1LineInput;
        private int x2LineInput;
        private int y2LineInput;
        private int widthLineInput;

        //Значения из полей ввода для круга
        private int xCircleInput;
        private int yCircleInput;
        private int radiusCircleInput;

        //Значения из полей ввода для многоугольника
        private int xPolygonPointInput;
        private int yPolygonPointInput;
        private int listBoxSelectedPoint = -1;
        private List<PointF> points = new List<PointF>();

        //Значения из полей ввода для правильного многоугольника
        private int xRegularPolygonInput;
        private int yRegularPolygonInput;
        private int rRegularPolygonInput;
        private int nRegularPolygonInput;

        private readonly Stack<LineDrawer> lineDrawers = new Stack<LineDrawer>();
        private readonly Stack<CircleDrawer> circleDrawers = new Stack<CircleDrawer>();
        private readonly Stack<PolygonDrawer> polygonDrawers = new Stack<PolygonDrawer>();

        private readonly Stack<RegularPolygonDrawer> regularPolygonDrawers = new Stack<RegularPolygonDrawer>();
        //todo update all canvas method private List<IDrawer> drawers = new List<IDrawer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            buttonGraphics.Enabled = false;
            buttonGraphics.Visible = false;

            buttonDrawLine.Enabled = true;
            buttonDrawLine.Visible = true;
            buttonEraseLine.Enabled = true;
            buttonEraseLine.Visible = true;

            buttonDrawCircle.Enabled = true;
            buttonDrawCircle.Visible = true;
            buttonEraseCircle.Enabled = true;
            buttonEraseCircle.Visible = true;

            buttonDrawPolygon.Enabled = true;
            buttonDrawPolygon.Visible = true;
            buttonErasePolygon.Enabled = true;
            buttonErasePolygon.Visible = true;

            buttonDrawRegularPolygon.Enabled = true;
            buttonDrawRegularPolygon.Visible = true;
            buttonEraseRegularPolygon.Enabled = true;
            buttonEraseRegularPolygon.Visible = true;
        }

        //Draw and erase methods

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            var lineDrawer = new LineDrawer(x1LineInput, y1LineInput, x2LineInput, y2LineInput, widthLineInput);
            lineDrawers.Push(lineDrawer);
            lineDrawer.Draw(g);
        }

        private void buttonEraseLine_Click(object sender, EventArgs e)
        {
            if (lineDrawers.Count <= 0)
                return;
            var lineDrawer = lineDrawers.Pop();
            lineDrawer.Erase(g);
            ////todo clear fields method
        }

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            var circleDrawer = new CircleDrawer(xCircleInput, yCircleInput, radiusCircleInput);
            circleDrawers.Push(circleDrawer);
            circleDrawer.Draw(g);
        }

        private void buttonEraseCircle_Click(object sender, EventArgs e)
        {
            if (circleDrawers.Count <= 0)
                return;
            var circleDrawer = circleDrawers.Pop();
            circleDrawer.Erase(g);
            ////todo clear fields method
        }

        private void buttonDrawPolygon_Click(object sender, EventArgs e)
        {
            if (points.Count < 2) return;
            var polygonDrawer = new PolygonDrawer(points);
            polygonDrawers.Push(polygonDrawer);
            polygonDrawer.Draw(g);
        }

        private void buttonErasePolygon_Click(object sender, EventArgs e)
        {
            if (polygonDrawers.Count <= 0)
                return;
            var polygonDrawer = polygonDrawers.Pop();
            polygonDrawer.Erase(g);

            //todo clear fields method
        }

        private void buttonDrawRegularPolygon_Click(object sender, EventArgs e)
        {
            if (nRegularPolygonInput <= 2) return;
            var regularPolygonDrawer = new RegularPolygonDrawer(xRegularPolygonInput, yRegularPolygonInput,
                rRegularPolygonInput, nRegularPolygonInput);
            regularPolygonDrawers.Push(regularPolygonDrawer);
            regularPolygonDrawer.Draw(g);
        }

        private void buttonEraseRegularPolygon_Click(object sender, EventArgs e)
        {
            if (regularPolygonDrawers.Count <= 0) return;
            var regularPolygonDrawer = regularPolygonDrawers.Pop();
            regularPolygonDrawer.Erase(g);
            //todo clear fields method
        }

        //Line inputs

        private void textBoxX1Line_TextChanged(object sender, EventArgs e)
        {
            x1LineInput = processInput(x1LineInput, textBoxX1.Text, labelX1, "X1");
        }

        private void textBoxY1Line_TextChanged(object sender, EventArgs e)
        {
            y1LineInput = processInput(y1LineInput, textBoxY1.Text, labelY1, "Y1");
        }

        private void textBoxX2Line_TextChanged(object sender, EventArgs e)
        {
            x2LineInput = processInput(x2LineInput, textBoxX2.Text, labelX2, "X2");
        }

        private void textBoxY2Line_TextChanged(object sender, EventArgs e)
        {
            y2LineInput = processInput(y2LineInput, textBoxY2.Text, labelY2, "Y2");
        }

        private void textBoxWidthLine_TextChanged(object sender, EventArgs e)
        {
            widthLineInput = processInput(widthLineInput, textBoxWidth.Text, labelWidth, "W");
        }

        //Circle inputs

        private void textBoxCircleX_TextChanged(object sender, EventArgs e)
        {
            xCircleInput = processInput(xCircleInput, textBoxCircleX.Text, labelCircleX, "X");
        }

        private void textBoxCircleY_TextChanged(object sender, EventArgs e)
        {
            yCircleInput = processInput(yCircleInput, textBoxCircleY.Text, labelCircleY, "Y");
        }

        private void textBoxCircleRadius_TextChanged(object sender, EventArgs e)
        {
            radiusCircleInput = processInput(radiusCircleInput, textBoxCircleRadius.Text, labelCircleRadius, "R");
        }

        //Polygon inputs

        private void buttonAddPolygonPoint_Click(object sender, EventArgs e)
        {
            if (labelPolygonX.Text != "X" && labelPolygonY.Text != "Y")
                return;
            points.Add(new Point(xPolygonPointInput, yPolygonPointInput));
            listBoxPolygon.Items.Add(new Point(xPolygonPointInput, yPolygonPointInput));
        }

        private void listBoxPolygon_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelectedPoint = listBoxPolygon.SelectedIndex;
        }

        private void buttonDeletePolygonPoint_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedPoint < 0 || listBoxSelectedPoint > points.Count) return;
            points.RemoveAt(listBoxSelectedPoint);
            listBoxPolygon.Items.RemoveAt(listBoxSelectedPoint);
            //listBoxPolygon.Items.Add()
        }

        private void textBoxPolygonY_TextChanged(object sender, EventArgs e)
        {
            yPolygonPointInput = processInput(yPolygonPointInput, textBoxPolygonY.Text, labelPolygonY, "Y");
        }

        private void textBoxPolygonX_TextChanged(object sender, EventArgs e)
        {
            xPolygonPointInput = processInput(xPolygonPointInput, textBoxPolygonX.Text, labelPolygonX, "X");
        }

        private static int processInput(int value, string input, Label label, string name)
        {
            int result = value;
            if (input == "")
            {
                label.Text = "Введите " + name;
                return result;
            }

            int tmp;
            bool isSuccess = int.TryParse(input, out tmp);
            if (isSuccess)
            {
                result = tmp;
                label.Text = name;
            }
            else
                label.Text = name + " Ошибка";

            return result;
        }

        //Regular polygon inputs

        private void textBoxRegularPolygonN_TextChanged(object sender, EventArgs e)
        {
            nRegularPolygonInput =
                processInput(nRegularPolygonInput, textBoxRegularPolygonN.Text, labelRegularPolygonN, "N");
        }

        private void textBoxRegularPolygonR_TextChanged(object sender, EventArgs e)
        {
            rRegularPolygonInput =
                processInput(rRegularPolygonInput, textBoxRegularPolygonR.Text, labelRegularPolygonR, "R");
        }

        private void textBoxRegularPolygonY_TextChanged(object sender, EventArgs e)
        {
            yRegularPolygonInput =
                processInput(yRegularPolygonInput, textBoxRegularPolygonY.Text, labelRegularPolygonY, "Y");
        }

        private void textBoxRegularPolygonX_TextChanged(object sender, EventArgs e)
        {
            xRegularPolygonInput =
                processInput(xRegularPolygonInput, textBoxRegularPolygonX.Text, labelRegularPolygonX, "X");
        }
    }
}