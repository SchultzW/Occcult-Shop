drop table Products;
create table Products(
  prodId number,
  Title varchar(20),
  Price number,
  descr varchar(100),
  tag varchar(20),
  imgPath varchar(200)
);

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(1,"Jar of Whispers",12.99,"Spruce up anyroom in your house with this jar filled with whispers of the unknown. Who knows what they will whisper (Legal Disclaimer: We are not responsible for Jar of Whispers telling you to sacrafice family members.","Home","http://placekitten.com/g/100/200");

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(2,"Unknown Book from the Library of Jurgen Leitner",20.99,"No one know what is held within the pages of this tome. All our interns that opened it were inflected with mind-boggline instantiy (Legal Disclaimer: We are not respobsible for any alteration to the sanity of purchaser.","Books","http://placekitten.com/g/100/200");

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(3,"Wooden Spoon",5.99,"A wooden spoon that is great for use in the kitchen","Home","http://placekitten.com/g/100/200");

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(4,"Necronomicon",12.99,"The Necronomicon has been a staple in any mystic's library. It contains accounts of the Old Ones, their history, and how to summon them.(Legal Disclaimer: We are not responsible for any personal physical or mental injury from attempting to perform a summoning ritural contained in this book.)","Book","http://placekitten.com/g/100/200");

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(5,"Garden Gome",15.50,"A small gnome can really spruce up anyones garden.","Home","http://placekitten.com/g/100/200");

insert into products
(prodId,title,price,descr,tag,imgPath)
values
(6,"Spirit Board",25.95,"A real spirit board to communicate with the great beyond. This is a great gift for teenagers that enjoy venturing into abandoned buildings or a birthday present for your favorite medium. (Legal Disclaimer: We are not responsible for any posessions that may come from using this product.","http://placekitten.com/g/100/200");
