using FurniFusion_E_Commerce_.Data;
using FurniFusion_E_Commerce_.Dtos.Profile.Address;
using FurniFusion_E_Commerce_.Interfaces;
using FurniFusion_E_Commerce_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace FurniFusion_E_Commerce_.Services
{
    public class AddressService : IAddressService
    {
        private readonly FurniFusionDbContext _context;

        public AddressService(FurniFusionDbContext context)
        {
            _context = context;
        }


        public async Task<UserAddress?> GetAddressAsync(int addressId, string userId)
        {
            var address = await _context.UserAddresses.FirstOrDefaultAsync(a => a.AddressId == addressId);

            if (address == null)
                return null;

            if (address.UserId != userId)
                return null;

            return address;
        }

        public async Task<List<UserAddress>> GetAllAddressesAsync(string userId)
        {
            var addresses = await _context.UserAddresses
                                          .Where(a => a.UserId == userId)
                                          .ToListAsync();

            return addresses;
        }

        public async Task<UserAddress?> AddAddressAsync(UserAddress address)
        {
            try
            {
                var createdAddress = await _context.UserAddresses.AddAsync(address);
                await _context.SaveChangesAsync();  // Ensure that changes are saved
                return createdAddress.Entity;
            }
            catch (Exception ex)
            {
                // You can log the error or add some context-specific information
                throw new Exception("An error occurred while adding the address.", ex);
            }
        }

        public async Task<UserAddress?> UpdateAddressAsync(UpdateAddressDto addressDto, string userId)
        {
            try
            {
                var address = await _context.UserAddresses.FirstOrDefaultAsync(a => a.AddressId == addressDto.AddressId);

                if (address == null)
                    return null;

                if (address.UserId != userId)
                    return null;

                address.Country = addressDto.Country ?? address.Country;
                address.City = addressDto.City ?? address.City;
                address.State = addressDto.State ?? address.State;
                address.Street = addressDto.Street ?? address.Street;
                address.PostalCode = addressDto.PostalCode ?? address.PostalCode;
                address.IsPrimaryAddress = addressDto.IsPrimaryAddress ?? address.IsPrimaryAddress;


                await _context.SaveChangesAsync();

                return address;

            }
            catch (Exception ex)
            {
                {
                    throw new Exception("An error occurred while updating the address.", ex);
                }
            }
        }

        public async Task<bool> DeleteAddressAsync(int addressId, string userId)
        {
            var address = await _context.UserAddresses.FirstOrDefaultAsync(a => a.AddressId == addressId);

            if (address == null)
                return false;

            if (address.UserId != userId)
                return false;

            _context.UserAddresses.Remove(address);

            await _context.SaveChangesAsync();

            return true;
        }



    }
}
