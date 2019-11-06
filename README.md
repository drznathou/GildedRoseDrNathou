
![](https://img.shields.io/badge/technology-.NetCore-blue) [![BCH compliance](https://bettercodehub.com/edge/badge/drznathou/GildedRoseDrNathou?branch=master)](https://bettercodehub.com/)

# Gilded Rose Refactoring Kata
## Note
This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedRose). See also [Bobby Johnson's description of the kata](http://iamnotmyself.com/2011/02/13/refactor-this-the-gilded-rose-kata/).

For this version of the original Kata, I chose to focus on refactoring and not so much on tests project. In fact,
I used a little hour of my time and the original project can be reworked in many ways.
In my solution, I divided the solution in 3 projects but many more target plateform could be added.

- A Core library in .NetCore which are responsible for the business logic and the data access.
- A Console Target project
- A xUnit Target test project
Any target project relies on the Core project. They need to have the autofac nugget installed [autofac repo](
https://github.com/autofac/Autofac). 


## Build this project

- Let Visual Studio restore nugget packages
- Just run the Console Target project. Done
