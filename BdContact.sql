--
-- Database: `dbContact`
--

-- --------------------------------------------------------

--
-- Table structure for table `Contact`
--

CREATE TABLE  Contact (
  id int(11) NOT NULL ,
  name varchar(25) NOT NULL,
  email varchar(50) NOT NULL,
  phone varchar(25) NOT NULL,
  adress varchar(250) NOT NULL,
  PRIMARY KEY (id)
);


-- --------------------------------------------------------