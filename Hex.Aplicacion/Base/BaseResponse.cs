using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Aplicacion.Base
{
    public class BaseResponse <T>
    {
        public bool IsSuccess { get; set; }
        public string? Mensage { get; set; }
        public List<string>? Errores {  get; set; }
        public T? Data {  get; set; }
    }
}
