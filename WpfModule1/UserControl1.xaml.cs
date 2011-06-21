using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfModule1 {
  /// <summary>
  /// Interaction logic for UserControl1.xaml
  /// </summary>
  public partial class UserControl1 : UserControl {
    public UserControl1() {
      InitializeComponent();
    }
  }

  public class UserControlViewBuilder {
    public UserControl1 BuildView() {
      return new UserControl1();
    }
  }
}
