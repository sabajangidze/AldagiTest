using Domain.Abstractions;
using Domain.Entities;

namespace Infrastructure.Data
{
    public static class DbInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            var clients = new Client[]
            {
                new Client
                {
                    ClientName = "Saba",
                    ClientCode = "S124Ad@4",
                    ContrAgentType = "Director",
                    ClientType = Domain.Enums.ClientType.Retail
                },
                new Client
                {
                    ClientName = "Dato",
                    ClientCode = "12342@4",
                    ContrAgentType = "Director",
                    ClientType = Domain.Enums.ClientType.SME
                }
            };

            foreach (var client in clients)
            {
                context.Clients.Add(client);
            }

            var schemes = new Scheme[]
            {
                new Scheme
                {
                    Name = "2023Scheme"
                }
            };

            foreach (var scheme in schemes)
            {
                context.Schemes.Add(scheme);
            }

            var licenses = new License[]
            {
                new License
                {
                    Name = "Product",
                    Percent = 12,
                    Type = Domain.Enums.PercentType.Monthly,
                    CascoType = "Casco",
                    TravelProduct = "Bag",
                    Scheme = schemes[0],
                    SchemeId = schemes[0].Id
                }
            };

            foreach (var license in licenses)
            {
                context.Licenses.Add(license);
            }

            var policyDetails = new PolicyDetail[]
            {
                new PolicyDetail{
                    ToDate = DateTime.UtcNow,
                    SchedulePay = 1200,
                    PaymentLeft = 500,
                    Source = "Georgia",
                    SellSegment = "Tbilisi",
                    OldPolicyNumber = "123SA5",
                    CurrentPaid = 700,
                }
            };

            foreach (var policyDetail in policyDetails)
            {
                context.PolicyDetails.Add(policyDetail);
            }

            var policies = new Policy[]
            {
                new Policy{PolicyNumber = "12SA52",
                    Status = true,
                    PaymentDate = new DateTime(2023, 1, 27, 12, 00,00),
                    FromDate = new DateTime(2023, 1, 27),
                    EventDate = new DateTime(2023, 12, 31),
                    IsLoss = false,
                    PremiumCurrency = "USD",
                    LimitCurrency = "USD",
                    CurName = "USD",
                    SumInsured = 102,
                    Intallment = "4",
                    EventOrderNo = 1234,
                    PayType = "Cash",
                    Comission = "Tbilisi",
                    Segment = "TBC",
                    SellSpot = "Georgia",
                    License = licenses[0],
                    Client = clients[0],
                    PolicyDetail = policyDetails[0],
                    PolicyDetailId = Guid.NewGuid()
                },
            };

            foreach (var policy in policies)
            {
                context.Policies.Add(policy);
            }

            context.SaveChanges();
        }
    }
}
