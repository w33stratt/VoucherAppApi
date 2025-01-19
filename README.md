# VoucherApp

This project is a Voucher and Redemption API built with .NET 9, EF Core, PostgreSQL and unit tests using xUnit.

## Features
- Create a brand
- Create a voucher
- Fetch a single voucher by ID
- Fetch all vouchers for a specific brand
- Redeem vouchers for a customer
- Fetch transaction redemption details

## Setup

1. Clone the repository.
2. Install dependencies using `dotnet restore`.
3. Create the PostgreSQL database and set connection string in `appsettings.json`.
4. Run migrations using `dotnet ef database update`.
5. Run the API with `dotnet run`.

## Endpoints

- POST /api/brand: Create a new brand.
- POST /api/voucher: Create a new voucher.
- GET /api/voucher/{voucherId}: Get voucher by ID.
- GET /api/voucher/brand?id={brandId}: Get vouchers by brand.
- POST /api/transaction/redemption: Create a redemption transaction.
- GET /api/transaction/redemption?transactionId={transactionId}: Get redemption transaction details.

## Testing

Run unit tests with `dotnet test`.
