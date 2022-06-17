using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter;

public class ChatRoom
{
    public const uint DescriptionMaxLength = 128;
    public ChatroomId Id { get; set; }
    public string Name { get; set; }


    private string _description;
    public string Description
    {
        get { return _description; }

        set
        {
            if (value.Length > DescriptionMaxLength)
            {
                throw new ArgumentOutOfRangeException($"max description length {DescriptionMaxLength}");
            }

            _description = value;
        }
    }

    public Uri Banner { get; set; }
}