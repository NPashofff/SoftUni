namespace MilitaryElite
{
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        public List<Private> Privates { get; set; }
    }
}
