using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_net
{
    /// <summary>
    /// Las expresiones, 
    /// (input-parameters) => expression
    /// 
    /// (input-parameters) => { <sequence-of-statements> }
    /// </summary>
    public class Lambda
    {
        Func<int, int> square => x => x * x;
        
        
    }
}
