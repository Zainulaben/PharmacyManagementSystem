# Pharmacy Management System

## Introduction
The healthcare sector involves frequent alterations in the legislature, patient needs, as well as technological advancements. Therefore, one can say that pharmacies represent not just drug distributors but important components of the health care system, responsible for accurate and rapid treatment processes. Henceforth, it is important to indicate that we are pleased to avail the Pharmacy Management System (PMS) project which is a comprehensive software solution aimed at rejuvenating and modernizing pharmacy operations as a result of these complications.
The pharmacies also act as intermediaries for this most vital role of the pharmaceuticals within the health care system which links together people and health professionals. However, a highly intelligent and broad-based approach involving the latest methodology must be adopted since there are numerous differences in the way that the drugs can work. The Pharmacy Management System Project intends to provide a basis on which pharmacies can develop, transform, and remain thriving amid the evolving healthcare setting.
The plan of this project gives detailed information about the objectives, limits, and likely benefits. Additionally, it offers a detailed description of the project management. Important objectives for the Pharmacy Management System Project are the ability to integrate and manage patient records, ensure a sound security strategy, bill services, process prescriptions, maintain an inventory, and report status. This integration would help the pharmacy to run at its best in ensuring that it upholds the needs of patients as they remain committed to them. In this chapter, the details mentioned will include the project’s details, anticipated results, and strategic implementation strategy. These serve as our guideposts, guiding us toward innovation while producing a modernized pharmacy administration system. The main objective is ensuring that pharmacies remain on the front line of healthcare delivery without losing focus on the objective of improving patient health and well-being in a dynamically shifting environment.

## Problem Statement
Modern-day pharmacies need to strike a balance between high precision, optimal throughput, and patient-oriented care while dealing with complex obligations. These demands cannot be adequately handled by the current manual and paper-based pharmacy management systems that result in mistakes while prescribing, ineffective inventory control, and cumbersome administrative processes. These are critical issues that would require an up-to-date PMS to harmonize pharmacies to reform health care. 

## Objectives
The PMS project is aimed at transforming and updating the practices related to pharmacy management. This project is designed to solve weaknesses in the existing manual and paper-based systems by implementing a modern software package to automate different functions involved in a pharmacy. The key objectives include:
- Increasing Efficiency: The objective of the PMS Project will be to replace labor-intensive manual processes with linked end–to–end software to effect massive cost and productivity improvements in pharmacy service operations. These will improve inventory control, reduce prescription handling errors, and minimize the administrative burden.
- Enhancing Data Management: The project will provide a robust mechanism for managing prescription, drug stocking, and patient information. This will enhance pharmacists’ ability to provide intelligent and informed patient care because they can easily access essential data.
- User-Friendly Interface: The system's user-friendly design will enable pharmacists and staff members with differing degrees of technological proficiency to utilize it. Its ease of use will guarantee effective use and promote acceptance.
- Adapting to Future Requirements: The PMS Project is future-focused and made to change to meet the ever-changing demands of the pharmaceutical and healthcare sectors. It will be adaptable and scalable, allowing it to take on new problems and advances in the future.

## Scope
The development, deployment, and ongoing support of a complete software solution designed to modernize and enhance pharmacy operations are all included in the scope of the Pharmacy Management System (PMS) Project. The project's goal is to handle all aspects of pharmacy administration, including inventory control and prescription processing, with an emphasis on patient safety, efficiency, and compliance.
The Pharmacy Management System (PMS) Project encompasses the entire lifecycle of a comprehensive software solution, covering development, deployment, and continuous support. Its overarching objective is to revolutionize and elevate pharmacy operations by modernizing existing systems. The project is designed to address every facet of pharmacy administration, placing particular emphasis on critical areas such as inventory control and prescription processing. The guiding principles of the PMS Project revolve around enhancing patient safety, operational efficiency, and ensuring compliance with regulatory standards.
Through meticulous development, seamless deployment, and sustained support, the PMS Project strives to create a transformative impact on the pharmacy landscape. It goes beyond a mere technological upgrade; it represents a strategic initiative to redefine and optimize pharmacy operations. By centralizing and streamlining administration processes, the project aims to enhance patient safety measures, improve operational efficiency, and ensure strict adherence to regulatory compliance.
In essence, the PMS Project is not just a software solution; it's a holistic approach to modernizing pharmacy practices. Its comprehensive scope underscores the commitment to delivering a system that addresses the dynamic needs of pharmacy administration, setting the stage for a more efficient, secure, and compliant future in pharmaceutical management.

## Database Code
```bash
  create database pms;
  use pms;

  create table admin_table(
    username varchar(15),
    password varchar(15)
  );

  Insert into admin_table(username,password) values("Admin123",246810);

  create table patient(
    ID int auto_increment primary key,
    username varchar(15),
    name varchar(20),
    password varchar(15),
    status varchar(15)
  );

  create table medicine(
    ID int auto_increment primary key,
    name varchar(15),
    type varchar(15),
    quantity int,
    price int,
    status varchar(15)
  );

  create table order_table(
    ID int auto_increment primary key,
    patient_ID int,
    order_date date,
    status varchar(15),
    foreign key(patient_ID) references patient(ID)
  );

  create table medicine_order(
    ID int auto_increment primary key,
    Order_ID int,
    Medicine_ID int,
    Quantity int,
    foreign key(Order_ID) references order_table(ID),
    foreign key(Medicine_ID) references medicine(ID)
  );

create table messages(
    ID int auto_increment primary key,
    Patient_ID int,
    message varchar(1000),
    foreign key(Patient_ID) references patient(ID)
  );
```
