#include "opencv2/highgui/highgui.hpp"
#include "opencv2/imgproc/imgproc.hpp"
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace cv;
using namespace std;
int main()
{

	/* //Блок рисования окна
	int height = 520;
	int width = 840;
	Mat img(height, width, CV_8UC3);
	Point textOrg(300, img.rows / 2);
	int fontFace = FONT_HERSHEY_SIMPLEX;
	double fontScale = 1;
	Scalar color(0, 0, 20);
	putText(img, "Step By Step", textOrg, fontFace, fontScale, color);
	namedWindow("Hello World", 0);
		imshow("Hello World", img);*/
	//Запрос от пользователя какой файл ему требуется открыть
	setlocale(LC_ALL, "Russian");
	string filename;
	cout << "Имя файла ";
	cin >> filename;
	cout << "Ввели файл "<<filename<<endl;

	



	//Блок загрузки изображения
	Mat img;
	img = imread(filename, 1); //image.jpg
	namedWindow("Hello World", WINDOW_AUTOSIZE);
	imshow("Hello World", img);
		waitKey(0);
		system("pause");
		return (0);
}