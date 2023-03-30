using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedeService.Enums;

namespace RedeService
{
    public class ChangeMessageEventArgs : EventArgs
    {
        public ChangeMessageEventArgs(Messages error, MessageColors messageColor) 
        { 
            Mensagem = error;
            NewColor = messageColor;
        }

        public ChangeMessageEventArgs(Messages error, MessageColors messageColor, Exception e)
        {
            Mensagem = error;
            NewColor = messageColor;
            ErrorMessage = e.Message;
        }

        public Messages Mensagem;
        public MessageColors NewColor;
        public String? ErrorMessage;
    }
}
