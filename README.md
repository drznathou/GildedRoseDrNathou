
![](https://img.shields.io/badge/technology-.NetCore-blue) [![BCH compliance](https://bettercodehub.com/edge/badge/drznathou/GildedRoseDrNathou?branch=master)](https://bettercodehub.com/)

# Gilded Rose Refactoring Kata
## Note
This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedRose). See also [Bobby Johnson's description of the kata](http://iamnotmyself.com/2011/02/13/refactor-this-the-gilded-rose-kata/).

For this version of the original Kata, I chose to focus on refactoring. The original project can be forked in many ways.
In my solution, I divided the solution in 3 projects
- A Core library in .NetCore which are responsible for the business logic and the data access.
- A Console Target project
- A xUnit Target test project
Any target project relies on the Core project. They need to have the autofac nugget installed [autofac repo](
https://github.com/autofac/Autofac). 

## Build this project

Just run the Console Target project. Done


## Better Code Hub
[![BCH compliance](https://bettercodehub.com/edge/badge/drznathou/GildedRoseDrNathou?branch=master)](https://bettercodehub.com/)
