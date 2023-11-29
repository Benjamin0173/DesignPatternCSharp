using System;
using TP.Interface;

class PageDecorator : LivreDecorator
{
    public PageDecorator(IBibliotheque bibliotheque) : base() { }


    public override string ObtenirLivres(){
        string livres = base.ObtenirLivres();
        return livres + " avec pagination";
    }

}
