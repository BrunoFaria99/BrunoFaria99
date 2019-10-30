using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHC3.Telas;
using AppHC3.Classes;

namespace AppHC3.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaAgendamentos : ContentPage
    {
        public TelaAgendamentos()
        {
            InitializeComponent();

            List<Agendamento> listaAgendamentos = new List<Agendamento>();
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
            listaAgendamentos.Add(new Agendamento { ImagemEspecialidade = "Icone_carta", DataAgendamento = "07/10/2019", Especialidade = "Ortopedia e Traumatologia" });
                       
            ListaAgendamentos.ItemsSource = listaAgendamentos;
        }
    }
}