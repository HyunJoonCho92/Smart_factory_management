DROP DATABASE factorydb; -- 만약 sqldb가 존재하면 우선 삭제한다.
CREATE DATABASE factorydb;
USE factorydb;

DROP TABLE employeeTbl;
CREATE TABLE employeeTbl -- 회원 테이블
( 
	ID CHAR(8) NOT NULL PRIMARY KEY, -- 사용자 아이디(PK)
	name VARCHAR(10) NOT NULL, -- 이름
	PW CHAR(10),
	birthYear INT NOT NULL,  -- 출생년도
	address CHAR(5) NOT NULL, -- 지역(경기,서울,경남 식으로 2글자만입력)
	mobile CHAR(15) -- 휴대폰의 국번(011, 016, 017, 018, 019, 010 등)
);

DROP TABLE factory1Tbl;
CREATE TABLE factory1Tbl -- 회원 구매 테이블(Buy Table의 약자)
(  
	f1_time DATETIME PRIMARY KEY,
	f1_temper SMALLINT,
	f1_humi SMALLINT
);

DROP TABLE warningTbl;
CREATE TABLE warningTbl
(
	w_time DATETIME PRIMARY KEY,
	factory SMALLINT,
	temper SMALLINT,
	humi SMALLINT
);

INSERT INTO employeeTbl VALUES('LSG', '이승기', '12345', 1987, '서울', '01011111111');


INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-12', 24, 40);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-13', 20, 30);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-14', 22, 20);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-15', 25, 60);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-16', 21, 70);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-17', 28, 40);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-18', 21, 60);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-19', 21, 60);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-21', 26, 80);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-22', 21, 30);
INSERT INTO factory1Tbl VALUES('2022-05-09-12-12-23', 24, 40);

INSERT INTO warningTbl VALUES('2022-05-09-12-12-23', 1 , 24, 40);
INSERT INTO warningTbl VALUES('2022-05-09-12-12-24', 1,  28, 50);

SELECT * FROM employeeTbl;

SELECT * FROM factory1Tbl;

SELECT * FROM warningTbl;