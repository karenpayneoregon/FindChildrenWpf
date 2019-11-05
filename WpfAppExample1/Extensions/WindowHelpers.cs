using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Windows.Media.VisualTreeHelper;

namespace WpfAppExample1.Extensions
{
    public static class WindowHelpers
    {
        /// <summary>
        /// Clear TextBox controls in a container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        public static void ClearTextBoxes<T>(this DependencyObject control)
        {
            foreach (var textBox in FindChildren<TextBox>(control))
            {
                textBox.Text = "";
            }
        }
        /// <summary>
        /// Enable or disable a TextBox in a container 
        /// 
        /// If Tag = R (need a better indicator) this TextBox  IsReadOnly is excluded as it's
        /// a read only TextBox always per business rules.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        public static void EnableTextBoxes<T>(this DependencyObject control, bool enable = false)
        {
            foreach (var textBox in FindChildren<TextBox>(control))
            {
                if (textBox.Tag?.ToString() == "R")
                {
                    continue;
                }

                textBox.IsReadOnly = enable;

                textBox.Background = textBox.IsReadOnly ?  
                    new SolidColorBrush(Color.FromArgb(255, 240, 240, 240)): 
                    Brushes.White;
            }
        }

        /// <summary>
        /// By setting Width this prevents horizontal resizing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <param name="width"></param>
        /// <remarks>
        /// Tag = A where A means nothing, need to have a better indicator
        /// </remarks>
        public static void SetTextBoxUniversalWidth<T>(this DependencyObject control, int width = 32)
        {
            foreach (var textBox in FindChildren<TextBox>(control))
            {
                if (textBox.Tag?.ToString() == "A")
                {
                    textBox.Width = width;
                }
            }
        }

        public static IEnumerable<T> FindChildren<T>(DependencyObject dependencyItem) where T : DependencyObject
        {
            if (dependencyItem != null)
            {
                for (var index = 0; index < GetChildrenCount(dependencyItem); index++)
                {
                    var child = GetChild(dependencyItem, index);
                    if (child is T dependencyObject)
                    {
                        yield return dependencyObject;
                    }

                    foreach (var childOfChild in FindChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}