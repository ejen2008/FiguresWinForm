using FiguresWinForm.Model;
using FiguresWinForm.Properties;
using FiguresWinForm.Serialize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresWinForm
{
    public partial class FormMovingFigures : Form
    {
        private BindingList<Figure> listOfFigures;
        private ComponentResourceManager resourceManager;
        private const string nameFileSaveData = "dataFigures";
        internal static Random randomObject = new Random();

        public FormMovingFigures()
        {
            InitializeComponent();
            listOfFigures = new BindingList<Figure>();
            ListBoxFiguresInitilize();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMovingFiguresLoad(object sender, EventArgs e)
        {
            MinimumSize = new Size(526, 345);
            pictureBoxMoving.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMoving.BackColor = Color.White;
            InitializeComboBox();
            resourceManager = new ComponentResourceManager(typeof(FormMovingFigures));
            DefaultLanguage();
            //Test();
        }

        private void ListBoxFiguresInitilize()
        {
            listBoxFigures.DataSource = listOfFigures;
            listBoxFigures.DisplayMember = "Name";
        }

        private void DefaultLanguage()
        {
            string culture = Thread.CurrentThread.CurrentUICulture.Name;
            if (culture == "ru-RU")
            {
                radioButtonRu.Checked = true;
            }
            else if (culture == "en")
            {
                radioButtonEn.Checked = true;
            }
        }

        private void ButtonTriangleClick(object sender, EventArgs e)
        {
            string figureName = resourceManager.GetString("buttonTriangle.Text");
            listOfFigures.Add(new Triangle(figureName));
        }

        private void ButtonCircleClick(object sender, EventArgs e)
        {
            string figureName = resourceManager.GetString("buttonCircle.Text");
            listOfFigures.Add(new Circle(figureName));
        }

        private void ButtonSquareClick(object sender, EventArgs e)
        {
            string figureName = resourceManager.GetString("buttonSquare.Text");
            listOfFigures.Add(new Square(figureName));
        }

        private void PictureBoxMovingPaint(object sender, PaintEventArgs e)
        {
            Point sizePictureBox = new Point
            {
                X = pictureBoxMoving.ClientSize.Width,
                Y = pictureBoxMoving.ClientSize.Height
            };
            foreach (Figure figure in listOfFigures)
            {
                if (figure.IsMoveFigure)
                {
                    figure.Move(sizePictureBox);
                }
                figure.Draw(e.Graphics);
            }
        }

        private void PictureBoxMovingMouseClick(object sender, MouseEventArgs e)
        {
            timerPictureBox.Stop();

            Figure clikcFigureMouse = FindFigureMouseClick(e.Location);

            listBoxFigures.SelectedItem = clikcFigureMouse;
            timerPictureBox.Start();
        }

        private Figure FindFigureMouseClick(Point pointMouseClick)// постараться упростить
        {
            Figure clickFigure = listOfFigures.FirstOrDefault(figure =>
            figure.LocationFigure.X <= pointMouseClick.X &&
            figure.LocationFigure.Y <= pointMouseClick.Y &&
            figure.LocationFigure.X + figure.SizeFigure >= pointMouseClick.X &&
            figure.LocationFigure.Y + figure.SizeFigure >= pointMouseClick.Y
            );
            return clickFigure;
        }

        private void TimerPictureBoxTick(object sender, EventArgs e)
        {
            pictureBoxMoving.Refresh();
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            Figure selectedFigure = listBoxFigures.SelectedItem as Figure;
            if (selectedFigure != null)
            {
                FigureChangeState(selectedFigure);
                ChangingNameButtonStartStop(selectedFigure);
            }
        }

        private void FigureChangeState(Figure figure)
        {
            if (figure.IsMoveFigure)
            {
                figure.IsMoveFigure = false;
            }
            else
            {
                figure.IsMoveFigure = true;
            }
        }

        private void ListBoxFiguresSelectedIndexChanged(object sender, EventArgs e)
        {
            Figure selectedFigure = listBoxFigures.SelectedItem as Figure;
            if (selectedFigure != null)
            {
                ChangingNameButtonStartStop(selectedFigure);
            }
        }

        private void ChangingNameButtonStartStop(Figure figure)
        {
            if (figure.IsMoveFigure)
            {
                buttonStopStart.Text = resourceManager.GetString("buttonStopText");
            }
            else
            {
                buttonStopStart.Text = resourceManager.GetString("buttonStartText");
            }
        }

        private void Test()
        {
            for (int i = 0; i <= 150; i++)
            {
                ButtonCircleClick(new Object(), new EventArgs());
                ButtonSquareClick(new Object(), new EventArgs());
                ButtonTriangleClick(new Object(), new EventArgs());
            }
        }

        private void InitializeComboBox()
        {
            string[] listOfSaveFormats = Enum.GetNames(typeof(ListOfSaveFormats));
            comboBoxSaveFormat.Items.AddRange(listOfSaveFormats);
            comboBoxSaveFormat.SelectedItem = listOfSaveFormats.FirstOrDefault();
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            string saveFormats = comboBoxSaveFormat.SelectedItem as string;
            ListOfSaveFormats format;
            if (Enum.TryParse(saveFormats, out format))
            {
                timerPictureBox.Stop();
                SaveFigures(format);
                timerPictureBox.Start();
            }
        }

        private void SaveFigures(ListOfSaveFormats format)
        {
            string filePath = Application.StartupPath + "\\";
            if (format == ListOfSaveFormats.Bin)
            {
                SerializeFigures(new BinFormatSerialize(), filePath + nameFileSaveData + ".bin");
            }
            else if (format == ListOfSaveFormats.JSON)
            {
                SerializeFigures(new JSONFormatSerialize(), filePath + nameFileSaveData + ".json");
            }
            else if (format == ListOfSaveFormats.XML)
            {
                SerializeFigures(new XMLFormatSerialize(), filePath + nameFileSaveData + ".xml");
            }
        }

        private void SerializeFigures(ISerialize serializeFormat, string filePath)
        {
            serializeFormat.WriteData(listOfFigures.ToList(), filePath);
        }
        private void ButtonLoadClick(object sender, EventArgs e)
        {
            string loadFormats = comboBoxSaveFormat.SelectedItem as string;
            ListOfSaveFormats format;
            if (Enum.TryParse(loadFormats, out format))
            {
                LoadFigures(format);
            }
            ListBoxFiguresInitilize();
        }

        private void LoadFigures(ListOfSaveFormats format)
        {
            string filePath = Application.StartupPath + "\\";
            if (format == ListOfSaveFormats.Bin)
            {
                DesialazeFigures(new BinFormatSerialize(), filePath + nameFileSaveData + ".bin");
            }
            else if (format == ListOfSaveFormats.JSON)
            {
                DesialazeFigures(new JSONFormatSerialize(), filePath + nameFileSaveData + ".json");
            }
            else if (format == ListOfSaveFormats.XML)
            {
                DesialazeFigures(new XMLFormatSerialize(), filePath + nameFileSaveData + ".xml");
            }
        }
        private void DesialazeFigures(ISerialize deserializeFormat, string filePath)
        {
            listOfFigures = new BindingList<Figure>(deserializeFormat.ReadData(filePath));
        }

        private void ButtonCleanClick(object sender, EventArgs e)
        {
            listOfFigures.Clear();
        }

        private void RadioButtonRuCheckedChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            resourceManager = new ComponentResourceManager(typeof(FormMovingFigures));
            ApplyResources(this, resourceManager);


        }
        private void RadioButtonEnCheckedChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            resourceManager = new ComponentResourceManager(typeof(FormMovingFigures));
            ApplyResources(this, resourceManager);
        }
        private void ApplyResources(Control ctrl, ComponentResourceManager manager)
        {
            manager.ApplyResources(ctrl, ctrl == this ? "$this" : ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResources(child, manager);
            }
        }
    }
}
