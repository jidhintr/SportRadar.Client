using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRadar.Client.ViewModels
{
    public class MainViewViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel = new AddGameViewModel();

        
        public BaseViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set => _selectedViewModel = value;
        }
    }
}
