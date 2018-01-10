using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace T576282
{
    public partial class UserControlCustomerEdit : UserControlNerpaBase
    {
        private BindingSource _bindingSource;
        public UserControlCustomerEdit()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            InitializeBindings();
           // InitializeValidationRules();
            FillCombobox();
            dxValidationProvider1.ValidationMode = ValidationMode.Auto;
        }

        private void InitializeValidationRules()
        {
            //CustomValidationRule customValidationRule = new CustomValidationRule(_bindingSource.DataSource);
            //customValidationRule.ErrorText = "Error";
            //dxValidationProvider1.SetValidationRule(textEditName, customValidationRule);
            //dxValidationProvider1.SetValidationRule(comboBoxEditCategory, customValidationRule);
        }

        private async void InitializeBindings()
        {
            _bindingSource.DataSource = await SimpleDataSource.GetTestData();
            textEditName.DataBindings.Add(new Binding(nameof(textEditName.Text), _bindingSource, nameof(SimpleDataSource.SimpleData.Name)));
            comboBoxEditCategory.DataBindings.Add(new Binding(nameof(comboBoxEditCategory.EditValue), _bindingSource, nameof(SimpleDataSource.SimpleData.Category)));
        }

        private async void FillCombobox()
        {
            foreach (var item in await SimpleDataSource.GetTestData(4))
                comboBoxEditCategory.Properties.Items.Add(item.Category);
        }
    }
    //public class CustomValidationRule : ValidationRule
    //{
    //    List<string> validNames;
    //    List<string> validCategories;
    //    public CustomValidationRule(object listOfValues) : base()
    //    {
    //        validNames = (listOfValues as BindingList<SimpleDataSource.SimpleData>).Select(i => i.Name).ToList();
    //        validCategories = (listOfValues as BindingList<SimpleDataSource.SimpleData>).GroupBy(i => i.Category).Select(g => g.First()).Select(s => s.Category).ToList();
    //    }
    //    public override bool Validate(Control control, object value)
    //    {
    //        if ((control.GetType().Equals(typeof(TextEdit)) && validNames.Contains(value.ToString()))
    //            || (control.GetType().Equals(typeof(ComboBoxEdit)) && validCategories.Contains(value.ToString())))
    //            return true;
    //        return false;
    //    }
    //}
}
