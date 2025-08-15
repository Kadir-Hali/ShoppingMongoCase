using AutoMapper;
using MongoDB.Driver;
using ShoppingMongoCase.Dtos.ProductImageDtos;
using ShoppingMongoCase.Entities;
using ShoppingMongoCase.Settings;

namespace ShoppingMongoCase.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<ProductImage> _productImageCollection;
        private readonly IMongoCollection<Product> _productCollection;

        public ProductImageService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _mapper = mapper;
            _productImageCollection = database.GetCollection<ProductImage>(_databaseSettings.ProductImageCollectionName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName); ;
        }

        public async Task CreateProductImageAsync(CreateProductImageDto createProductImageDto)
        {
            var productImage = _mapper.Map<ProductImage>(createProductImageDto);
            await _productImageCollection.InsertOneAsync(productImage);
        }

        public async Task DeleteProductImageAsync(string id)
        {
            await _productImageCollection.DeleteOneAsync(x => x.ProductImageId == id);
        }

        public Task<List<ResultProductImageDto>> GetAllProductImageAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetProductImageDto> GetProductImageByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
        {
            throw new NotImplementedException();
        }
    }
}
