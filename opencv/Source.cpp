#include "opencv2/highgui/highgui.hpp" //определяет кросс-платформенные функции взаимодействия с оконной системой;
#include "opencv2/imgproc/imgproc.hpp" // определяет основные/традиционные функции цифровой обработки изображений: отрисовка кривых и тому подобное.
#include <iostream> // Объявляет объекты, управляющие чтением из стандартных потоков и записью в них. Это, как правило, единственный заголовок, необходимый для ввода и вывода из программы на C++.
#include <stdio.h>  // стандартный заголовочный файл ввода-вывода
#include <stdlib.h> // аголовочный файл стандартной библиотеки языка Си, который содержит в себе функции, занимающиеся выделением памяти, контролем процесса выполнения программы, преобразованием типов и другие
using namespace cv; 
using namespace std;
int main()
{

	 //Блок рисования окна
	//int height = 520; // задаем высоту (int - тип данных, целое)
	//int width = 840; // задаем ширину
	//Mat img(height, width, CV_8UC3); // Mat(создание матрицы) (CV_8UC3) 8-разрядная целочисленная матрица / изображение без знака с 3 каналами
	//Point textOrg(300, img.rows / 2); //Point (координаты x,y) , 
	//int fontFace = FONT_HERSHEY_SIMPLEX; //настройка шрифта , FONT_HERSHEY_SIMPLEX - тип шрифта
	//double fontScale = 1; //double - числовой тип данных , fontScale — переменная типа double, коэффициент масштабирования шрифта, умножаемый на базовый размер шрифта.
	//Scalar color(0, 0, 20); // Тип Scalar широко используется в OpenCV для передачи значений пикселей, цвет
	//putText(img, "Step By Step", textOrg, fontFace, fontScale, color); //  используется для рисования текстовой строки на любом изображении
	//namedWindow("Hello World", 0); // название окна
	//	imshow("Hello World", img);  //отображает изображение в градациях серого на рисунке. использует диапазон отображения по умолчанию для типа данных изображения и оптимизирует свойства рисунка, осей и объекта изображения для отображения изображения
	//Запрос от пользователя какой файл ему требуется открыть
	//setlocale(LC_ALL, "Russian"); //русификатор
	//string filename; //строчка с названием перменной 
	//cout << "Имя файла "; //вывод значения <<
	//cin >> filename;  // ввод значения >>
	//cout << "Ввели файл "<<filename<<endl; //endl текст будет выведен на след. строке 

	



	//Блок загрузки изображения
	Mat img; //создает матрицу
	img = imread("image1.jpg", 1); //image.jpg (imread -  считывает изображение из файла, заданного , выводя формат файла из его содержимого.)
	namedWindow("Hello World", WINDOW_AUTOSIZE); // название окна, авторазмер
	imshow("Hello World", img); // отображает изображение в градациях серого на рисунке. использует диапазон отображения по умолчанию для типа данных изображения и оптимизирует свойства рисунка, осей и объекта изображения для отображения изображения
	Mat src_gray;
	Mat canny_output;
	cvtColor(img, src_gray, COLOR_RGB2BGR);
	blur(src_gray, src_gray, Size(3, 3));
	/*double otsu_thresh_val = threshold(src_gray, img, 0, 255, THRESH_BINARY | THRESH_OTSU);*/
	/*double high_thresh_val = otsu_thresh_val, lower_thresh_val = otsu_thresh_val * 0.5;*/
	/*cout << otsu_thresh_val;*/
	double lower_thresh_val=100, high_thresh_val= 300;
	Canny(src_gray, canny_output,lower_thresh_val, high_thresh_val, 3);
	/*char* source_grey_window = "Серое изображение";*/
	namedWindow("Серое изображение", WINDOW_AUTOSIZE);
	imshow("Серое изображение", canny_output);
	imwrite("canny_output.jpg", canny_output);
	waitKey(0);
		system("pause");
		return (0);



	


		




}
