using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingCGI2.Pages.modul4
{
    public class ChatVM
    {
        public Action onAdd;

        public List<string> ChatListe { get; set; } = new List<string>();

        public void Add(string msg)
        {
            ChatListe.Add(msg);
            onAdd?.Invoke();
        }
    }
}
