using System.Windows;

namespace ItemTemplatePropertySetting
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var firstEntity = new MyEntity() { Text = "parentText", Type = "parentType" };
            var secondEntity = new MyEntity() { Text = "childText", Type = "childType" };
            firstEntity.Children.Add(secondEntity);
            treeView.Items.Add(firstEntity);
        }
    }
}
