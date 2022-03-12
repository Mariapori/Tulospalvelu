using Microsoft.EntityFrameworkCore;

namespace Tulospalvelu.Data
{
    public class TilastoService
    {
        private DataContext _context = new DataContext();

        public Task<List<Tilasto>> HaeTilastot()
        {
            return Task.FromResult(_context.Tilastot.Include(o => o.vieras).Include(o => o.koti).ToList());
        }

        public Task<List<Joukkue>> HaeJoukkueet()
        {
            return Task.FromResult(_context.Joukkueet.ToList());
        }

        public bool LisaaJoukkue(Joukkue model)
        {
            try
            {
                _context.Joukkueet.Add(model);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }

        }

        public bool PoistaJoukkue(Joukkue model)
        {
            try
            {
                _context.Joukkueet.Remove(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool MuokkaaJoukkue(Joukkue model, string UusNimi)
        {
            try
            {
                model.Nimi = UusNimi;
                _context.Joukkueet.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
