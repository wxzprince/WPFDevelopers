﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFDevelopers.Controls
{
    public class RollLoading : ContentControl
    {
        // Using a DependencyProperty as the backing store for ForegroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForegroundColorProperty =
            DependencyProperty.Register("ForegroundColor", typeof(Color), typeof(RollLoading),
                new PropertyMetadata(Colors.Red));

        // Using a DependencyProperty as the backing store for IsStart.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsStartProperty =
            DependencyProperty.Register("IsStart", typeof(bool), typeof(RollLoading), new PropertyMetadata(true));

        static RollLoading()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RollLoading),
                new FrameworkPropertyMetadata(typeof(RollLoading)));
        }


        public Color ForegroundColor
        {
            get => (Color)GetValue(ForegroundColorProperty);
            set => SetValue(ForegroundColorProperty, value);
        }


        public bool IsStart
        {
            get => (bool)GetValue(IsStartProperty);
            set => SetValue(IsStartProperty, value);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}