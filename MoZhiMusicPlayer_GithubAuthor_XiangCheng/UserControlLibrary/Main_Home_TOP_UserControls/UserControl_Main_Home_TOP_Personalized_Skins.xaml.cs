﻿using MoZhiMusicPlayer_GithubAuthor_XiangCheng.Models.APP_Personalized_Skin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VisioForge.Libs.MediaFoundation.OPM;

namespace MoZhiMusicPlayer_GithubAuthor_XiangCheng.UserControlLibrary.Main_Home_TOP_UserControls
{
    /// <summary>
    /// UserControl_Main_Home_TOP_Personalized_Skins.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl_Main_Home_TOP_Personalized_Skins : UserControl
    {
        public UserControl_Main_Home_TOP_Personalized_Skins()
        {
            InitializeComponent();

            /*gradientBrush_1 = new LinearGradientBrush(
                Color.FromRgb(67, 67, 67), Colors.Black, new Point(0, 0), new Point(1, 0));
            gradientBrush_1.GradientStops.Add(new GradientStop(Colors.Black, 1.0));

            gradientBrush_2 = new LinearGradientBrush();
            gradientBrush_2.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_2.EndPoint = new Point(1, 0);   // 渐变的结束点         
            gradientBrush_2.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#d5d4d0"), 1));
            gradientBrush_2.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#d5d4d0"), 0.75));
            gradientBrush_2.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#eeeeec"), 0.31));
            gradientBrush_2.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#efeeec"), 0.1));
            gradientBrush_2.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#e9e9e7"), 0));
            //background-image: linear-gradient(to top, #d5d4d0 0%, #d5d4d0 1%, #eeeeec 31%, #efeeec 75%, #e9e9e7 100%);

            gradientBrush_3 = new LinearGradientBrush();
            gradientBrush_3.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_3.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_3.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#868f96"), 0));
            gradientBrush_3.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#596164"), 1));


            gradientBrush_4 = new LinearGradientBrush();
            gradientBrush_4.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_4.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_4.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#537895"), 0));
            gradientBrush_4.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#09203f"), 1));


            gradientBrush_5 = new LinearGradientBrush();
            gradientBrush_5.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_5.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_5.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#485563"), 0));
            gradientBrush_5.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#29323c"), 1));*/


            gradientBrush_6 = new LinearGradientBrush();
            gradientBrush_6.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_6.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_6.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFFEFF"), 0));
            gradientBrush_6.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#D7FFFE"), 1));

            gradientBrush_7 = new LinearGradientBrush();
            gradientBrush_7.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_7.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_7.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#dfe9f3"), 0));
            gradientBrush_7.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#ffffff"), 1));

            gradientBrush_8 = new LinearGradientBrush();
            gradientBrush_8.StartPoint = new Point(0, 0); // 渐变的起始点
            gradientBrush_8.EndPoint = new Point(1, 0);   // 渐变的结束点
            gradientBrush_8.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#E3FDF5"), 0));
            gradientBrush_8.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FFE6FA"), 1));





            /* Border_this_app_Background_1.Background = gradientBrush_1;
             Border_this_app_Background_2.Background = gradientBrush_2;
             Border_this_app_Background_3.Background = gradientBrush_3;
             Border_this_app_Background_4.Background = gradientBrush_4;
             Border_this_app_Background_5.Background = gradientBrush_5;*/

            Path_App = System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + @"Resource";
            ImageBrush imageBrush;

            imageBrush = new ImageBrush(new BitmapImage(new Uri(Path_App + "/Button_Image_Ico/Music_Album.png")));
            imageBrush.Stretch = Stretch.UniformToFill;
            Border_this_app_Background_1.Background = imageBrush;

            imageBrush = new ImageBrush(new BitmapImage(new Uri(Path_App + "/Button_Image_Ico/Music_Album.png")));
            imageBrush.Stretch = Stretch.UniformToFill;
            Border_this_app_Background_2.Background = imageBrush;

            imageBrush = new ImageBrush(new BitmapImage(new Uri(Path_App + "/Button_Image_Ico/Music_Album.png")));
            imageBrush.Stretch = Stretch.UniformToFill;
            Border_this_app_Background_3.Background = imageBrush;

            imageBrush = new ImageBrush(new BitmapImage(new Uri(Path_App + "/Button_Image_Ico/Music_Album.png")));
            imageBrush.Stretch = Stretch.UniformToFill;
            Border_this_app_Background_4.Background = imageBrush;

            imageBrush = new ImageBrush(new BitmapImage(new Uri(Path_App + "/Button_Image_Ico/Music_Album.png")));
            imageBrush.Stretch = Stretch.UniformToFill;
            Border_this_app_Background_5.Background = imageBrush;

            Border_this_app_Background_6.Background = gradientBrush_6;
            Border_this_app_Background_7.Background = gradientBrush_7;
            Border_this_app_Background_8.Background = gradientBrush_8;
        }

        string Path_App;


       /* // 高级黑
        public LinearGradientBrush gradientBrush_1;

        // 高级白
        public LinearGradientBrush gradientBrush_2;

        // 山岩
        public LinearGradientBrush gradientBrush_3;

        // 永恒天空
        public LinearGradientBrush gradientBrush_4;

        // 毒药
        public LinearGradientBrush gradientBrush_5;*/

        // 盐山 
        public LinearGradientBrush gradientBrush_6;

        // 玻璃水
        public LinearGradientBrush gradientBrush_7;

        // 完美白
        public LinearGradientBrush gradientBrush_8;



        // 用户自定义
        public ImageBrush ImageBrush_this_app_Background = new ImageBrush();
    }
}
