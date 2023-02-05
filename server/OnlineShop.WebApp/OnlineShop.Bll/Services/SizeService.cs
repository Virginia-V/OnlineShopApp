using AutoMapper;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common;
using OnlineShop.Common.Dtos.Sizes;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Bll.Services
{
    public class SizeService : ISizeService
    {
        private readonly IRepository<Size> _sizeRepository;
        private readonly IMapper _mapper;

        public SizeService(IRepository<Size> sizeRepository, IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SizeDto>> GetSizesAsync()
        {
            var records = await _sizeRepository.GetAllAsync();
            if (!records.Any())
            {
                throw new ValidationException(ErrorMessages.NoSizes);
            }
            return _mapper.Map<IEnumerable<SizeDto>>(records);
        }
    }
}
