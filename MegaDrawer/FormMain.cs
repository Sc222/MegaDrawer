using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
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
        
        private readonly Dictionary<Type, Drawer> lastDrawers = Drawer.InitDrawersDictionary();
        private readonly List<Drawer> removeCandidates = new List<Drawer>();
        private readonly LinkedList<Drawer> drawers = new LinkedList<Drawer>();
        
        public FormMain() => InitializeComponent();

        private void FormMain_Load(object sender, EventArgs e)
        {
            AllocConsole();
            g = panelDrawCanvas.CreateGraphics();
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        private void UpdateLastObjectDrawers(Dictionary<Type,Drawer>lastDrawersTemp)
        {
            foreach (var drawer in lastDrawersTemp)
                lastDrawers[drawer.Key] = drawer.Value;
        }
        
        private void RedrawAllObjects()
        {
            g.Clear(Color.White);
            var lastDrawersTemp = Drawer.InitDrawersDictionary();
            for(var drawer = drawers.First; drawer != null;)
            {
                var next = drawer.Next;
                if (removeCandidates.Contains(drawer.Value)) 
                {
                    drawers.Remove(drawer);
                    removeCandidates.Remove(drawer.Value);
                }
                else
                {
                    var drawerType = drawer.Value.GetType();
                    if (lastDrawersTemp.ContainsKey(drawerType))
                        lastDrawersTemp[drawerType] = drawer.Value;
                    drawer.Value.Draw(g);
                }
                drawer = next;
            }
            UpdateLastObjectDrawers(lastDrawersTemp);
        }
        
        private void UpdateValuesAndDrawObject(Drawer drawer)
        {
            lastDrawers[drawer.GetType()] = drawer;
            drawers.AddLast(drawer);
            drawer.Draw(g);
        }
        
        private void EraseObjectIfExists(Type drawerType)
        {
            if (lastDrawers[drawerType] == null)
                return;
            removeCandidates.Add(lastDrawers[drawerType]);
            RedrawAllObjects();
        }
        
        //Draw and erase methods

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            var lineDrawer = new LineDrawer(x1LineInput, y1LineInput, x2LineInput, y2LineInput, widthLineInput);
            //todo check for input errors
            UpdateValuesAndDrawObject(lineDrawer);
        }
        
        
        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            var circleDrawer = new CircleDrawer(xCircleInput, yCircleInput, radiusCircleInput);
            //todo check for input errors
            UpdateValuesAndDrawObject(circleDrawer);
        }
        
        private void buttonDrawPolygon_Click(object sender, EventArgs e)
        {
            if (points.Count <= 2) return;
            var polygonDrawer = new PolygonDrawer(points);
            //todo check for input errors
            UpdateValuesAndDrawObject(polygonDrawer);
        }
        
        private void buttonDrawRegularPolygon_Click(object sender, EventArgs e)
        {
            if (nRegularPolygonInput <= 2) return;
            var regularPolygonDrawer = new RegularPolygonDrawer(xRegularPolygonInput, yRegularPolygonInput,
                rRegularPolygonInput, nRegularPolygonInput);
            //todo check for input errors
            UpdateValuesAndDrawObject(regularPolygonDrawer);
        }

        private void buttonEraseLine_Click(object sender, EventArgs e) => EraseObjectIfExists(typeof(LineDrawer));

        private void buttonEraseCircle_Click(object sender, EventArgs e) => EraseObjectIfExists(typeof(CircleDrawer));

        private void buttonErasePolygon_Click(object sender, EventArgs e) => EraseObjectIfExists(typeof(PolygonDrawer));
        
        private void buttonEraseRegularPolygon_Click(object sender, EventArgs e) => EraseObjectIfExists(typeof(RegularPolygonDrawer));

        //Line inputs

        private void textBoxX1Line_TextChanged(object sender, EventArgs e)
        {
            x1LineInput = ProcessInput(x1LineInput, textBoxX1.Text, labelX1, "X1");
        }

        private void textBoxY1Line_TextChanged(object sender, EventArgs e)
        {
            y1LineInput = ProcessInput(y1LineInput, textBoxY1.Text, labelY1, "Y1");
        }

        private void textBoxX2Line_TextChanged(object sender, EventArgs e)
        {
            x2LineInput = ProcessInput(x2LineInput, textBoxX2.Text, labelX2, "X2");
        }

        private void textBoxY2Line_TextChanged(object sender, EventArgs e)
        {
            y2LineInput = ProcessInput(y2LineInput, textBoxY2.Text, labelY2, "Y2");
        }

        private void textBoxWidthLine_TextChanged(object sender, EventArgs e)
        {
            widthLineInput = ProcessInput(widthLineInput, textBoxWidth.Text, labelWidth, "W");
        }

        //Circle inputs

        private void textBoxCircleX_TextChanged(object sender, EventArgs e)
        {
            xCircleInput = ProcessInput(xCircleInput, textBoxCircleX.Text, labelCircleX, "X");
        }

        private void textBoxCircleY_TextChanged(object sender, EventArgs e)
        {
            yCircleInput = ProcessInput(yCircleInput, textBoxCircleY.Text, labelCircleY, "Y");
        }

        private void textBoxCircleRadius_TextChanged(object sender, EventArgs e)
        {
            radiusCircleInput = ProcessInput(radiusCircleInput, textBoxCircleRadius.Text, labelCircleRadius, "R");
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
        }

        private void textBoxPolygonY_TextChanged(object sender, EventArgs e)
        {
            yPolygonPointInput = ProcessInput(yPolygonPointInput, textBoxPolygonY.Text, labelPolygonY, "Y");
        }

        private void textBoxPolygonX_TextChanged(object sender, EventArgs e)
        {
            xPolygonPointInput = ProcessInput(xPolygonPointInput, textBoxPolygonX.Text, labelPolygonX, "X");
        }
        
        private static int ProcessInput(int value, string input, Control label, string name)
        {
            int result = value;
            if (input == "")
            {
                label.Text = $"Введите {name}";
                return result;
            }

            var isSuccess = int.TryParse(input, out var tmp);
            if (isSuccess)
            {
                result = tmp;
                label.Text = name;
            }
            else
                label.Text = $"{name} Ошибка";

            return result;
        }

        //Regular polygon inputs

        private void textBoxRegularPolygonN_TextChanged(object sender, EventArgs e)
        {
            nRegularPolygonInput =
                ProcessInput(nRegularPolygonInput, textBoxRegularPolygonN.Text, labelRegularPolygonN, "N");
        }

        private void textBoxRegularPolygonR_TextChanged(object sender, EventArgs e)
        {
            rRegularPolygonInput =
                ProcessInput(rRegularPolygonInput, textBoxRegularPolygonR.Text, labelRegularPolygonR, "R");
        }

        private void textBoxRegularPolygonY_TextChanged(object sender, EventArgs e)
        {
            yRegularPolygonInput =
                ProcessInput(yRegularPolygonInput, textBoxRegularPolygonY.Text, labelRegularPolygonY, "Y");
        }

        private void textBoxRegularPolygonX_TextChanged(object sender, EventArgs e)
        {
            xRegularPolygonInput =
                ProcessInput(xRegularPolygonInput, textBoxRegularPolygonX.Text, labelRegularPolygonX, "X");
        }
    }
}