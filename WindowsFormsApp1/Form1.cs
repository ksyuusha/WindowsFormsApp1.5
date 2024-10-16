using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Перечисление для выбора типа фигуры
        private enum Shape
        {
            Line,        // Линия
            Rectangle,   // Прямоугольник
            Circle       // Круг
        }

        // Переменные для состояния рисования
        private Shape currentShape = Shape.Line;  // Текущий выбранный инструмент
        private bool isDrawing = false;  // Определяет, рисуем ли мы в данный момент
        private Point startPoint;  // Начальная точка при рисовании
        private Point endPoint;    // Конечная точка при рисовании
        private readonly Pen drawingPen = new Pen(Color.Black, 2);  // Кисть для рисования
        private readonly Bitmap canvasBitmap;  // Буферизованное изображение для рисования
        private readonly Graphics canvasGraphics;  // Графика для рисования на холсте

        public Form1()
        {
            InitializeComponent();
            // Инициализация холста для рисования
            canvasBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White); // Очистка холста (заполнение белым цветом)
            drawingPanel.BackgroundImage = canvasBitmap;  // Привязка холста к панели для рисования
        }

        // Обработчики кнопок выбора фигур
        private void BtnLine_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Line;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Rectangle;
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Circle;
        }

        // Обработчик для кнопки выбора цвета
        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    drawingPen.Color = colorDialog.Color;
                }
            }
        }

        // Событие нажатия кнопки мыши в панели рисования
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;  // Начало рисования
            startPoint = e.Location;  // Запоминаем начальную точку
        }

        // Событие перемещения мыши (во время рисования)
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;  // Обновляем конечную точку
                drawingPanel.Invalidate();  // Обновляем панель для перерисовки
            }
        }

        // Событие отпускания кнопки мыши
        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;  // Завершаем рисование
            endPoint = e.Location;  // Обновляем конечную точку
            DrawShape(canvasGraphics);  // Рисуем окончательную фигуру на постоянном холсте
        }

        // Перерисовка панели (для динамического отображения фигуры при рисовании)
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                DrawShape(e.Graphics);  // Временно рисуем на графике панели
            }
        }

        // Метод для рисования выбранной фигуры
        private void DrawShape(Graphics g)
        {
            switch (currentShape)
            {
                case Shape.Line:
                    g.DrawLine(drawingPen, startPoint, endPoint);
                    break;
                case Shape.Rectangle:
                    g.DrawRectangle(drawingPen, GetRectangle(startPoint, endPoint));
                    break;
                case Shape.Circle:
                    g.DrawEllipse(drawingPen, GetCircle(startPoint, endPoint));  // Для круга используем GetCircle
                    break;
            }
        }

        // Метод для вычисления прямоугольника (для рисования прямоугольника)
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),  // Левая верхняя точка по X
                Math.Min(p1.Y, p2.Y),  // Левая верхняя точка по Y
                Math.Abs(p1.X - p2.X), // Ширина
                Math.Abs(p1.Y - p2.Y)  // Высота
            );
        }

        // Метод для вычисления окружности (на основе квадрата)
        private Rectangle GetCircle(Point p1, Point p2)
        {
            int width = Math.Abs(p2.X - p1.X);
            int height = Math.Abs(p2.Y - p1.Y);

            // Выбираем минимальное значение, чтобы окружность была правильной
            int diameter = Math.Min(width, height);

            return new Rectangle(
                Math.Min(p1.X, p2.X),   // Верхняя левая точка по X
                Math.Min(p1.Y, p2.Y),   // Верхняя левая точка по Y
                diameter,               // Диаметр по ширине
                diameter                // Диаметр по высоте (чтобы был круг)
            );
        }
    }
}
