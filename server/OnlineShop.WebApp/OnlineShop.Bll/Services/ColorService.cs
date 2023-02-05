using AutoMapper;
using OnlineShop.Bll.Interfaces;
using OnlineShop.Common;
using OnlineShop.Common.Dtos.Colors;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Bll.Services
{
    public class ColorService : IColorService
    {
        private readonly IRepository<Color> _colorRepository;
        private readonly IMapper _mapper;

        public ColorService(IRepository<Color> colorRepository, IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ColorDto>> GetColorsAsync()
        {
            var records = await _colorRepository.GetAllAsync();
            if (!records.Any())
            {
                throw new ValidationException(ErrorMessages.NoColors);
            }
            return _mapper.Map<IEnumerable<ColorDto>>(records);
        }
    }
}
