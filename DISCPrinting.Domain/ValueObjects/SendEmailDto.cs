using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISCPrinting.Domain.ValueObjects;

public class SendEmailDto
{
    public List<string> To { get; set; }
    public List<string> Bcc { get; set; }
    public List<string> Cc { get; set; }
    public string Subject { get; set; }
    public string From { get; set; }
    public string Content { get; set; }
}
