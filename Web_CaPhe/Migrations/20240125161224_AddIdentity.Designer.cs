﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_CaPhe.Data;

#nullable disable

namespace Web_CaPhe.Migrations
{
    [DbContext(typeof(CoffeeshopDbContext))]
    [Migration("20240125161224_AddIdentity")]
    partial class AddIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web_CaPhe.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Web_CaPhe.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Web_CaPhe.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrendingProduct")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Phở is a traditional Vietnamese noodle soup consisting of broth, rice noodles, herbs, and meat, typically beef or chicken. The broth is simmered with various spices like star anise, cinnamon, and cloves, giving it a rich and aromatic flavor.",
                            ImageUrl = "https://fantasea.vn/wp-content/uploads/2018/08/Ph%E1%BB%9F.jpg",
                            IsTrendingProduct = false,
                            Name = "Phở",
                            Price = 25m
                        },
new
{
    Id = 2,
    Detail = "Bánh mì is a Vietnamese sandwich made with a baguette filled with various savory ingredients such as grilled pork, Vietnamese sausage, pickled vegetables, and fresh herbs.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Banh_mi_thit_nga_baguette.jpg/800px-Banh_mi_thit_nga_baguette.jpg",
    IsTrendingProduct = false,
    Name = "Bánh mì",
    Price = 10m
},
new
{
    Id = 3,
    Detail = "Bún chả is a Vietnamese dish of grilled pork served with rice vermicelli noodles, herbs, and a dipping sauce. It's typically eaten with fresh greens and pickled vegetables.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/B%C3%BAn_ch%E1%BA%A3.jpg/800px-B%C3%BAn_ch%E1%BA%A3.jpg",
    IsTrendingProduct = false,
    Name = "Bún chả",
    Price = 20m
},
new
{
    Id = 4,
    Detail = "Cà phê sữa đá is a Vietnamese iced coffee made with strong drip coffee mixed with sweetened condensed milk and poured over ice. It's a popular and refreshing drink in Vietnam.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/C%C3%A0_ph%C3%AA_s%E1%BB%AFa_%C4%91%C3%A1_h%E1%BB%93ng_h%C3%B2a.jpg/800px-C%C3%A0_ph%C3%AA_s%E1%BB%AFa_%C4%91%C3%A1_h%E1%BB%93ng_h%C3%B2a.jpg",
    IsTrendingProduct = false,
    Name = "Cà phê sữa đá",
    Price = 5m
},
new
{
    Id = 5,
    Detail = "Gỏi cuốn, also known as Vietnamese spring rolls or fresh spring rolls, are made with rice paper filled with shrimp, pork, herbs, rice vermicelli, and vegetables. They're often served with a dipping sauce.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Vietnamese-rolls.jpg/800px-Vietnamese-rolls.jpg",
    IsTrendingProduct = false,
    Name = "Gỏi cuốn",
    Price = 15m
},
new
{
    Id = 6,
    Detail = "Bánh xèo is a Vietnamese savory pancake made from rice flour, water, turmeric powder, filled with shrimp, pork, bean sprouts, and then folded. It's often served with fresh herbs and lettuce for wrapping.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/B%C3%A1nh_x%C3%A8o_t%C6%B0%C6%A1i_Nam_%C4%90%E1%BB%8Bnh.jpg/800px-B%C3%A1nh_x%C3%A8o_t%C6%B0%C6%A1i_Nam_%C4%90%E1%BB%8Bnh.jpg",
    IsTrendingProduct = false,
    Name = "Bánh xèo",
    Price = 18m
},
new
{
    Id = 7,
    Detail = "Bánh cuốn is a Vietnamese dish of steamed rice rolls filled with minced pork, wood ear mushrooms, and shallots. It's served with dipping sauce and often accompanied by Vietnamese sausage and steamed bean sprouts.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/B%C3%A1nh_cu%E1%BB%91n_h%C3%A0ng_b%C3%A0_%C4%91%E1%BB%99ng.jpg/800px-B%C3%A1nh_cu%E1%BB%91n_h%C3%A0ng_b%C3%A0_%C4%91%E1%BB%99ng.jpg",
    IsTrendingProduct = false,
    Name = "Bánh cuốn",
    Price = 12m
},
new
{
    Id = 8,
    Detail = "Bún riêu is a Vietnamese soup made with a tomato-based broth, crab or shrimp paste, tofu, and pork. It's served with rice vermicelli noodles, topped with crab meat, pork, and various herbs.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/B%C3%BAn_ri%C3%AAu_cua_t%C3%B4m.jpg/800px-B%C3%BAn_ri%C3%AAu_cua_t%C3%B4m.jpg",
    IsTrendingProduct = false,
    Name = "Bún riêu",
    Price = 22m
},
new
{
    Id = 9,
    Detail = "Cơm tấm, also known as broken rice, is a Vietnamese dish made from fractured rice grains. It's served with various toppings such as grilled pork, shredded pork skin, and a side of pickled vegetables.",
    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/C%C6%A1m_t%E1%BA%A5m_s%C3%A0i_g%C3%B2n.JPG/800px-C%C6%A1m_t%E1%BA%A5m_s%C3%A0i_g%C3%B2n.JPG",
    IsTrendingProduct = false,
    Name = "Cơm tấm",
    Price = 17m
});
                });

            modelBuilder.Entity("Web_CaPhe.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Web_CaPhe.Models.OrderDetail", b =>
                {
                    b.HasOne("Web_CaPhe.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_CaPhe.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Web_CaPhe.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Web_CaPhe.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Web_CaPhe.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
