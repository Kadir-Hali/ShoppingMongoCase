using AutoMapper;
using MongoDB.Driver;
using ShoppingMongoCase.Dtos.SliderDtos;
using ShoppingMongoCase.Entities;
using ShoppingMongoCase.Settings;

namespace ShoppingMongoCase.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;

        public SliderService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }
        public Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSliderAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetSliderDto> GetSliderByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            throw new NotImplementedException();
        }
    }
}
