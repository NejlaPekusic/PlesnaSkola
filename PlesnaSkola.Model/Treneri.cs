using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Treneri
    {
        public int Id { get; set; }
        public Korisnici_Basic Korisnik { get; set; }
        public string Licenca { get; set; }
        public Funkcija Funkcija { get; set; }
        public string NazivFunkcije => Funkcija.ToString();

        public override string ToString()
        {
            return Korisnik.Ime + " " + Korisnik.Prezime;
        }

    }
    public enum Funkcija { Koreograf, Kondicioni, Tehnički }

}
