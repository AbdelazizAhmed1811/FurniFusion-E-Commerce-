﻿using FurniFusion_E_Commerce_.Dtos.Profile.Address;
using FurniFusion_E_Commerce_.Models;

namespace FurniFusion_E_Commerce_.Interfaces
{
    public interface IAddressService
    {
        Task<UserAddress?> AddAddressAsync(UserAddress address);

        Task<UserAddress?> UpdateAddressAsync(UpdateAddressDto addressDto, string userId);

        Task<bool> DeleteAddressAsync(int addressId, string userId);
        Task<UserAddress?> GetAddressAsync(int addressId, string userId);

        Task<List<UserAddress>> GetAllAddressesAsync(string userId);

    }
}
