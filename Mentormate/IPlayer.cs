using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate
{
    public interface IPlayer
    {
        string Name { get; }
        int PlayerSince { get; }
        string Position { get; }
        double Rating { get; }
    }
}
