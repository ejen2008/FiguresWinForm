using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace FiguresWinForm.Model
{
    [DataContract]
    [Serializable]
    public abstract class Figure
    {
        private const int maxDistanseStep = 4;
        private const int minDistanceStep = -4;
        private const int minSizeFigure = 15;
        private const int maxSizeFigure = 30;
        [DataMember]
        private bool wasBeginPoint;
        private Point vectorAndSpeedMovement;
        private Point locationFigure;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Point LocationFigure
        {
            get
            {
                return locationFigure;
            }
            set
            {
                locationFigure = value;
            }
        }
        [DataMember]
        public Point VectorAndSpeedMovement
        {
            get
            {
                return vectorAndSpeedMovement;
            }
            set
            {
                vectorAndSpeedMovement = value;
            }
        }
        [DataMember]
        public bool IsMoveFigure { get; set; }
        [DataMember]
        public int SizeFigure { get; set; }
        public Figure()
        {
            wasBeginPoint = true;
                }
        public Figure(string name)
        {
            Name = name;
            vectorAndSpeedMovement = GetVectorAndMovement();
            SizeFigure = InitializeSizeFigure();
            IsMoveFigure = true;
        }

        public abstract void Draw(Graphics g);

        public void Move(Point sizePictureBox)
        {
            if (wasBeginPoint == true)
            {
                NextStep(sizePictureBox);
            }
            else
            {
                LocationFigure = GetBeginPointFigure(sizePictureBox);
                wasBeginPoint = true;
            }
        }

        private Point GetBeginPointFigure(Point sizePictureBox)
        {
            Point point = new Point
            {
                X = FormMovingFigures.randomObject.Next(sizePictureBox.X - SizeFigure),
                Y = FormMovingFigures.randomObject.Next(sizePictureBox.Y - SizeFigure)
            };
            return point;
        }

        private Point GetVectorAndMovement()
        {
            Point point = new Point
            {
                X = FormMovingFigures.randomObject.Next(minDistanceStep, maxDistanseStep),
                Y = FormMovingFigures.randomObject.Next(minDistanceStep, maxDistanseStep)
            };
            if (point.X == 0)
            {
                point.X = maxDistanseStep;
            }
            if (point.Y == 0)
            {
                point.Y = minDistanceStep;
            }
            return point;
        }

        private void NextStep(Point sizePictureBox)
        {
            Point locationSecondAngle = new Point
            {
                X = LocationFigure.X + SizeFigure,
                Y = LocationFigure.Y + SizeFigure
            };

            ChangingVector(sizePictureBox, locationSecondAngle);

            NextStepIfFigureOutPictureBox(sizePictureBox, locationSecondAngle);

            NextStepIfFigureDidnotMoveYet(sizePictureBox, locationSecondAngle);
        }

        private void ChangingVector(Point sizePictureBox, Point locationSecondAngle)
        {
            if (LocationFigure.X < 0 || locationSecondAngle.X > sizePictureBox.X)
            {
                vectorAndSpeedMovement.X = -vectorAndSpeedMovement.X;
            }
            if (LocationFigure.Y < 0 || locationSecondAngle.Y > sizePictureBox.Y)
            {
                vectorAndSpeedMovement.Y = -vectorAndSpeedMovement.Y;
            }
        }

        private void NextStepIfFigureOutPictureBox(Point sizePictureBox, Point locationSecondAngle)
        {
            if (locationSecondAngle.X > sizePictureBox.X)
            {
                locationFigure.X = sizePictureBox.X - SizeFigure;
            }
            if (locationSecondAngle.Y > sizePictureBox.Y)
            {
                locationFigure.Y = sizePictureBox.Y - SizeFigure;
            }
        }

        private void NextStepIfFigureDidnotMoveYet(Point sizePictureBox, Point locationSecondAngle)
        {
            if (LocationFigure.X > 0 || locationSecondAngle.X < sizePictureBox.X)
            {
                DoingNextStepX();
            }
            if (LocationFigure.Y > 0 || locationSecondAngle.Y < sizePictureBox.Y)
            {
                DoingNextStepY();
            }
        }

        private int InitializeSizeFigure()
        {
            return FormMovingFigures.randomObject.Next(minSizeFigure, maxSizeFigure);
        }

        private void DoingNextStepX()
        {
            locationFigure.X = LocationFigure.X + vectorAndSpeedMovement.X;
        }

        private void DoingNextStepY()
        {
            locationFigure.Y = LocationFigure.Y + vectorAndSpeedMovement.Y;
        }

    }
}
