
create table Restaurant(
    Id int identity,
    Name varchar(40),
    City varchar(30),
    State varchar(30),

    constraint pk_restaurant primary key (Id)
);

select * from Restaurant;

insert into Restaurant(Name, City, State)
    values  ('Stephen Restaurant', 'Houston', 'Texas'),
            ('Michael Restaurant', 'Orlando', 'Florida'),
            ('Travis Restaurant','Austin','Texas');

create table Review(
    Id int identity,
    RestaurantId int,
    Rating decimal(10, 2),
    Description varchar(255),

    constraint pk_review primary key (Id),
    constraint fk_review_restaurant foreign key (RestaurantId) references Restaurant(Id)
);

insert into Review(RestaurantId, Rating, Description)
    values  (1, 3.5, 'It was ok food'),
            (1, 4.7, 'It was awesome'),
            (2, 4.6, 'It was the best'),
            (2, 3.8, 'It was meh');

select * from Review;

drop table Review;
drop table Restaurant;
