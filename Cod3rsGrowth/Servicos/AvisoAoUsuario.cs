using System.Windows.Forms;

namespace Cod3rsGrowth.Servicos
{
    public class AvisoAoUsuario
    {
        public static void ModalAviso(string text)
        {
            MessageBox.Show(text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static DialogResult ModalConfirmarAcao(string text)
        {
            return MessageBox.Show(text, "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}
