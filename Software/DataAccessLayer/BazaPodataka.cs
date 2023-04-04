using EntitiesLayer;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class BazaPodataka : DbContext
    {
        public BazaPodataka()
            : base("name=BazaPodataka")
        {
        }

        public virtual DbSet<KategorijaLjubimca> KategorijaLjubimcas { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Lijekovi> Lijekovis { get; set; }
        public virtual DbSet<Ljubimac> Ljubimacs { get; set; }
        public virtual DbSet<PasminaLjubimca> PasminaLjubimcas { get; set; }
        public virtual DbSet<PosjetaLjubimca> PosjetaLjubimcas { get; set; }
        public virtual DbSet<PreboljeleBolesti> PreboljeleBolestis { get; set; }
        public virtual DbSet<Raspored> Rasporeds { get; set; }
        public virtual DbSet<TipKorisnika> TipKorisnikas { get; set; }
        public virtual DbSet<TipStanice> TipStanices { get; set; }
        public virtual DbSet<VeterinarskaStanica> VeterinarskaStanicas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KategorijaLjubimca>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<KategorijaLjubimca>()
                .HasMany(e => e.PasminaLjubimcas)
                .WithRequired(e => e.KategorijaLjubimca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.BrojMobitela)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.KorisnickoIme)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Ljubimacs)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.PosjetaLjubimcas)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Rasporeds)
                .WithRequired(e => e.Korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lijekovi>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Lijekovi>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Ljubimac>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Ljubimac>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Ljubimac>()
                .Property(e => e.Biljeske)
                .IsUnicode(false);

            modelBuilder.Entity<Ljubimac>()
                .HasMany(e => e.PosjetaLjubimcas)
                .WithRequired(e => e.Ljubimac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ljubimac>()
                .HasMany(e => e.Rasporeds)
                .WithRequired(e => e.Ljubimac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PasminaLjubimca>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<PasminaLjubimca>()
                .HasMany(e => e.Ljubimacs)
                .WithRequired(e => e.PasminaLjubimca)
                .HasForeignKey(e => e.TipLjubimcaID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PosjetaLjubimca>()
                .Property(e => e.RazlogPosjete)
                .IsUnicode(false);

            modelBuilder.Entity<PosjetaLjubimca>()
                .HasMany(e => e.Lijekovis)
                .WithRequired(e => e.PosjetaLjubimca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PosjetaLjubimca>()
                .HasMany(e => e.PreboljeleBolestis)
                .WithRequired(e => e.PosjetaLjubimca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreboljeleBolesti>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<PreboljeleBolesti>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Raspored>()
                .Property(e => e.OpisZauzetosti)
                .IsUnicode(false);

            modelBuilder.Entity<TipKorisnika>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<TipKorisnika>()
                .HasMany(e => e.Korisniks)
                .WithRequired(e => e.TipKorisnika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipStanice>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<TipStanice>()
                .HasMany(e => e.VeterinarskaStanicas)
                .WithRequired(e => e.TipStanice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VeterinarskaStanica>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<VeterinarskaStanica>()
                .Property(e => e.AdresaStanice)
                .IsUnicode(false);
        }
    }
}
