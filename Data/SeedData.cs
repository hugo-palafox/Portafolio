using Portafolio.Models;

namespace Portafolio.Data;

public static class SeedData
{
    public static readonly HomeContent Home = new()
    {
        Name = "Hugo Palafox",
        Headline = "Robotics & Automation Systems Engineer",
        Subheadline = "Robotics Integration · PLC Control Systems · Embedded Edge · OT-IT Architecture",
        Description = "I design and deploy automation systems across robotics, PLC control, embedded edge infrastructure, and industrial software—delivering production-ready systems end-to-end.",
        Pillars =
        [
            new()
            {
                Title = "Robotics Integration & Cell Architecture",
                Description = "Design robot cells, define process sequencing, and execute commissioning across machine interfaces, EOAT, and safety boundaries.",
                IconName = "bot"
            },
            new()
            {
                Title = "PLC Control & Machine Orchestration",
                Description = "Develop state machines, robot-PLC handshakes, and deterministic I/O orchestration for reliable cycle execution and recovery.",
                IconName = "cpu"
            },
            new()
            {
                Title = "Embedded Edge Deployment",
                Description = "Build embedded Linux deployment infrastructure for repeatable provisioning, runtime consistency, and field update reliability.",
                IconName = "chip"
            },
            new()
            {
                Title = "Industrial Software & OT-IT Interfaces",
                Description = "Develop industrial software platforms that normalize machine data and expose operational context for diagnostics and integration.",
                IconName = "network"
            }
        ],
        Metrics =
        [
            new() { Value = "10+ Years", Label = "Industrial automation & robotics engineering" },
            new() { Value = "100% Simulation Alignment", Label = "Digital twin validation matched the physical system at deployment" },
            new() { Value = "20x Faster Updates", Label = "Embedded edge rollout accelerated through automated flashing workflows" },
            new() { Value = "20 Machines", Label = "Multi-site IIoT deployment footprint across local and out-of-state equipment" }
        ]
    };

    public static readonly IReadOnlyList<Project> Projects =
    [
        new()
        {
            Id = "proj-rsr",
            Slug = "replenishment-robotics-system",
            Title = "Replenishment Robotics System",
            Category = "Robotics",
            ShortSummary = "Designed and actively developed replenishment robotics system that coordinates robot workflows, PLC machine states, EOAT behavior, and dispenser interaction.",
            Problem = "Manual replenishment introduced inconsistent timing, frequent operator intervention, and avoidable machine interruptions.",
            ArchitectureSummary = "Structured the system around robot task orchestration, PLC interlocks, machine-state handshakes, and a defined interface path for future AMR-assisted material transport.",
            Role = "Owned robotics system boundaries, PLC-robot interface design, EOAT integration direction, and commissioning strategy across controls and software layers.",
            TechnicalChallenges = "Deterministic handoff between machine and robot states, constrained cell geometry, recovery logic under faults, and maintaining reliable cycle behavior as workflows expanded.",
            TechStack = ["Fanuc", "TwinCAT", "C#", "Industrial Vision"],
            Outcome = "Progressed from concept into active system development with validated integration workflows and production-oriented implementation direction.",
            Tags = ["In Progress", "Robot Cell", "PLC Integration", "Machine Integration"],
            HeroImage = "/images/projects/Replen-image1.png",
            GalleryImages = ["/images/projects/Replen-image1.png"],
            Featured = true,
            SortOrder = 1
        },
        new()
        {
            Id = "proj-eoat",
            Slug = "eoat-simulation-to-reality-workflow",
            Title = "EOAT Design and Simulation-to-Reality Workflow",
            Category = "Robotics",
            ShortSummary = "Built a repeatable EOAT workflow from CAD and simulation through prototype validation and commissioning readiness.",
            Problem = "Late-stage tooling changes during launch created downtime, repeated debugging cycles, and delayed production acceptance.",
            ArchitectureSummary = "Established a traceable workflow linking mechanical design revisions, simulation scenarios, payload assumptions, and controls acceptance criteria before floor deployment.",
            Role = "Led cross-domain execution between mechanical design, robot programming, and controls to drive EOAT decisions from virtual validation to real cell readiness.",
            TechnicalChallenges = "Maintaining simulation fidelity against real payload behavior, tolerance variation, and mechanical revision drift across prototype iterations.",
            TechStack = ["Roboguide", "SolidWorks"],
            Outcome = "Delivered EOAT solutions into production while advancing additional prototype tooling through a structured path to commissioning.",
            Tags = ["Delivered", "Prototype", "EOAT", "Simulation-to-Reality"],
            HeroImage = "/images/projects/EOAT-1-CAD.png",
            GalleryImages =
            [
                "/images/projects/EOAT-1-CAD.png",
                "/images/projects/EOAT-1.png",
                "/images/projects/EOAT-2-CAD.png",
                "/images/projects/EOAT-2.png",
                "/images/projects/Reachability-test_0.png",
                "/images/projects/Reachability-test_1.png",
                "/images/projects/Reachability-test_3.png"
            ],
            Featured = true,
            SortOrder = 2
        },
        new()
        {
            Id = "proj-dispense-platform",
            Slug = "embedded-deployment-infrastructure-automation",
            Title = "Embedded Deployment Infrastructure for Automated Dispensing Systems",
            Category = "Embedded Systems",
            ShortSummary = "Designed and built a productized deployment toolkit for embedded dispensing systems, including automation scripts, operator utilities, and portable update hardware.",
            Problem = "Manual update procedures across production machines caused deployment delays, configuration drift, and inconsistent field execution.",
            ArchitectureSummary = "Implemented a standardized deployment workflow combining script-driven provisioning, operator-guided tooling, and portable updater hardware to make updates repeatable on the plant floor.",
            Role = "Owned system design and implementation of deployment automation, operator interfaces, and portable updater prototype for field-ready execution.",
            TechnicalChallenges = "Coordinating updates across embedded Linux nodes and PLC-connected machine states while minimizing downtime and preserving rollback reliability.",
            TechStack = ["Python", "C#", "PowerShell", "Linux", "Jetson", "Raspberry Pi"],
            Outcome = "Standardized deployment and update operations into a reusable workflow that reduced variability and improved operational repeatability.",
            Tags = ["Delivered", "Production", "Platform", "Embedded Systems"],
            HeroImage = "/images/projects/updater.png",
            GalleryImages = ["/images/projects/updater.png"],
            Featured = true,
            SortOrder = 3
        },
        new()
        {
            Id = "proj-jetson",
            Slug = "jetson-som-deployment-infrastructure",
            Title = "Jetson SOM Deployment Infrastructure",
            Category = "Embedded Edge",
            ShortSummary = "Engineered deployment and update infrastructure for Jetson SOM systems used in industrial vision and automation workloads.",
            Problem = "Manual flashing and runtime inconsistency across edge devices created rollout risk and unstable field behavior.",
            ArchitectureSummary = "Designed a repeatable deployment architecture including standardized BSP/image baselines, automated flashing workflows, parallel provisioning pipelines, and post-flash validation to enable consistent and scalable embedded system rollouts.",
            TechnicalChallenges = "Transforming a manual, multi-device flashing process into a scalable deployment workflow; unifying Windows/Linux tooling into a single operator interface; enabling parallel flashing and provisioning of multiple SOMs; handling partially provisioned devices with no network configuration; and meeting aggressive rollout timelines across hundreds of units.",
            Outcome = "Enabled high-throughput deployment by flashing up to 20 devices in parallel, accelerating rollout from sequential provisioning to batch-based execution; standardized system configuration across all units; and replaced manual multi-tool workflows with a unified, operator-friendly deployment system.",
            Role = "Owned deployment architecture, BSP/runtime consistency strategy, and rollout standards for reliable field updates.",
            TechStack = ["Jetson", "Ubuntu", "Python", "Bash", "PowerShell"],
            Tags = ["Delivered", "Production", "Embedded Updates", "Edge Linux"],
            HeroImage = "/images/projects/jetson-hero.png",
            MediaSectionTitle = "System Diagrams & Deployment Flow",
            MediaBlocks =
            [
                new()
                {
                    Title = "Deployment Architecture",
                    ImagePath = "/images/projects/jetson-1.jpg",
                    Caption = "Standardized BSP images, flash tooling, and post-flash validation are organized as one deployment architecture to keep runtime behavior consistent across every SOM."
                }
            ],
            GalleryImages = ["/images/projects/jetson-1.jpg"],
            Featured = true,
            SortOrder = 4
        },
        new()
        {
            Id = "proj-amr",
            Slug = "amr-agv-material-transport-architecture",
            Title = "AMR Bins Transport Architecture",
            Category = "System Architecture",
            ShortSummary = "Defined architecture for AMR material transport interfaces supporting replenishment and machine logistics workflows.",
            Problem = "Material transfer between mobile platforms and fixed automation assets lacked clear handoff logic, timing guarantees, and scalable system boundaries.",
            ArchitectureSummary = "Designed transport orchestration concepts, docking/handoff interface definitions, and control-boundary rules between mobile robots and machine automation.",
            Role = "Owned architecture definition across AMR behavior interfaces, machine integration points, and future staging/dispatch structure.",
            TechnicalChallenges = "Docking repeatability, transport-to-manipulation boundaries, traffic rule modeling, and scalable handoff contracts for future expansion.",
            TechStack = ["MQTT", "TwinCAT", "REST APIs", "MiR250", "Omron LD", "Python", "SQL Server", "ASP.NET Core API"],
            Outcome = "Established a practical integration architecture to guide future implementation of mobile material transport in automated cells.",
            Tags = ["Architecture", "Exploratory", "Prototype", "AMR"],
            HeroImage = "/images/projects/amr-hero.png",
            GalleryImages =
            [
                "/images/projects/amr-1.png",
                "/images/projects/amr-2.png",
                "/images/projects/amr-3.png",
                "/images/projects/amr-4.png"
            ],
            Featured = true,
            SortOrder = 5
        },
        new()
        {
            Id = "proj-plc-ai",
            Slug = "plc-to-ai-machine-interface",
            Title = "PLC-to-AI Machine Interface",
            Category = "OT-IT Integration",
            ShortSummary = "Built an exploratory proof of concept that exposes structured PLC machine context to AI tools for diagnostics and engineering assistance.",
            Problem = "AI workflows lacked safe, structured machine-state context, limiting practical industrial diagnostics use cases.",
            ArchitectureSummary = "Implemented a controlled interface layer that maps PLC state data into AI-consumable context while preserving controls-layer separation and OT-IT boundaries.",
            Role = "Defined the interface model and implemented PLC-to-AI data access patterns for exploratory engineering workflows.",
            TechnicalChallenges = "Maintaining context integrity, avoiding unsafe control-path exposure, and keeping AI interaction read-oriented within machine safety constraints.",
            TechStack = ["TwinCAT", "C#", "Python", "MCP"],
            Outcome = "Validated a credible path for AI-assisted machine diagnostics without positioning AI as direct plant-floor automation control.",
            Tags = ["Exploratory", "Prototype", "OT-IT"],
            HeroImage = "/images/projects/plc-ai-hero.png",
            GalleryImages = ["/images/projects/plc-ai-hero.png"],
            Featured = true,
            SortOrder = 6
        },
        new()
        {
            Id = "proj-datahub",
            Slug = "industrial-data-hub-edge-platform",
            Title = "Industrial Data Hub Edge Platform",
            Category = "Industrial Software",
            ShortSummary = "Defined and developed the architecture for an industrial edge data platform to unify PLC, vision, and machine telemetry into a reusable operational model.",
            Problem = "Fragmented machine data across controls and software stacks slowed diagnostics, obscured root causes, and limited engineering feedback.",
            ArchitectureSummary = "Defined platform architecture around protocol adapters, normalized machine-context models, edge buffering, and application interfaces for diagnostics and reporting.",
            Role = "Owned platform direction, integration patterns, and system interface design across OT data sources and software consumers.",
            TechnicalChallenges = "Cross-vendor protocol variation, schema evolution, and resilient data flow under intermittent plant-network conditions.",
            TechStack = ["MQTT", "C#", "SQL Server", "Grafana"],
            Outcome = "Produced an architecture baseline for a productizable industrial data platform and future deployment roadmap.",
            Tags = ["Architecture", "Platform", "Product Direction", "OT-IT", "Exploratory"],
            HeroImage = "/images/projects/idh-hero.png",
            GalleryImages = ["/images/projects/idh-hero.png"],
            Featured = true,
            SortOrder = 7
        },
        new()
        {
            Id = "proj-battery-data-platform",
            Slug = "battery-testing-data-platform",
            Title = "Battery Testing Data Platform (Full-Stack Industrial Workflow)",
            Category = "Industrial Software",
            ShortSummary = "Developed a full-stack system to process, structure, store, and visualize battery testing data across multiple test systems and facilities, including cloud-backed storage and data access.",
            Problem = "Battery testing results were generated as raw files without structured processing, limiting traceability, accessibility, and engineering analysis.",
            ArchitectureSummary = "Implemented a pipeline combining a Python backend service for file ingestion and processing, a .NET API for database interaction, Azure SQL for centralized data storage, OneDrive for file management, and a Blazor UI for data access and visualization.",
            Role = "Designed and built the end-to-end system, including backend processing services, database schema, API layer, frontend application, and integration with cloud-based storage and database services.",
            TechnicalChallenges = "Parsing and transforming raw test data, maintaining consistency across multiple test sources, managing file storage across local and cloud environments, and ensuring reliable data synchronization.",
            TechStack = ["Delivered","Python", "C#", ".NET API", "Blazor", "SQL Server", "Azure SQL", "OneDrive"],
            Outcome = "Enabled structured battery test data tracking, improved accessibility for engineers across locations, and established a scalable workflow integrating local systems with cloud-based storage and data services.",
            Tags = ["Full-Stack", "Data Pipeline", "Industrial Software", "Traceability", "Multi-Site", "Cloud Integration"],
            HeroImage = "/images/projects/battery-hero.png",
            GalleryImages = ["/images/projects/battery-hero.png"],
            Featured = true,
            SortOrder = 8
        },
        new()
        {
            Id = "proj-ultrasonic-welding",
            Slug = "automation-ultrasonic-welding-robot-dual-zone",
            Title = "Ultrasonic Welding Automation with 6-Axis Robot and Dual-Zone Cell",
            Category = "Robotics",
            ShortSummary = "Designed and deployed a dual-zone robotic ultrasonic welding cell, converting a manual process into a production automation system.",
            Problem = "Manual ultrasonic welding constrained throughput, increased labor dependency, and introduced quality variation under production demand.",
            ArchitectureSummary = "Implemented a dual-zone architecture with 6-axis robot operations, PLC-coordinated sequencing, and synchronized zone handoffs for continuous output.",
            Role = "Owned end-to-end execution from concept architecture and component sourcing to robot/PLC programming, integration, and startup.",
            TechnicalChallenges = "Meeting cycle-time targets with safe multi-zone coordination, commissioning during live production constraints, and stabilizing process repeatability.",
            TechStack = ["6-Axis Robots", "PLC Controls", "HMI", "Industrial I/O", "Ultrasonic Welding"],
            Outcome = "Delivered a production cell that increased throughput, reduced labor burden, and improved weld-process consistency.",
            Tags = ["Delivered", "Production", "Robot Welding", "PLC Integration"],
            HeroImage = "/images/projects/dual-zone-robot-welding-cell.jpg",
            GalleryImages =
            [
                "/images/projects/robot-welding-cell-1.jpg",
                "/images/projects/robot-welding-cell-2.jpg",
                "/images/projects/robot-welding-cell-4.jpg"
            ],
            Featured = true,
            SortOrder = 9
        },
        new()
        {
            Id = "proj-iiot-dashboard",
            Slug = "industrial-iot-dashboard-platform",
            Title = "Industrial IoT Platform for Multi-Site PLC Data Integration",
            Category = "Industrial Software",
            ShortSummary = "Built and deployed a full-stack IIoT platform from scratch to integrate multi-brand PLC data across distributed machines and sites.",
            Problem = "The prior model cost about $1,000 per machine annually plus roughly $8,000 upfront deployment and integration, while still limiting visibility across machines with weak or missing network infrastructure.",
            ArchitectureSummary = "Designed the complete system architecture: custom PLC drivers, edge data collection nodes, local database deployment, dashboard services, and flexible networking using mini PCs, compute sticks, and routers; also prototyped optional cloud database paths for remote monitoring.",
            Role = "Owned full lifecycle execution including PLC interface development, data collection strategy, database architecture, network design, hardware selection, deployment planning, and multi-site rollout coordination with IT.",
            TechnicalChallenges = "Building stable cross-vendor PLC drivers, collecting data from poorly connected machines, maintaining reliable edge-to-database flow, and scaling deployment standards across sites.",
            TechStack = ["C#", ".NET", "SQL Server", "Python", "TCP/Serial", "Industrial Networking", "PLC Integration"],
            Outcome = "Deployed across 24 machines (20 local, 4 out-of-state), removed recurring subscription cost dependency, and significantly reduced deployment overhead while expanding operational visibility.",
            Tags = ["Delivered", "Production", "Multi-Site Deployment", "IIoT", "Edge Systems"],
            HeroImage = "/images/projects/iiot-dashboard-hero.jpg",
            GalleryImages =
            [
                "/images/projects/iiot-dashboard-1.jpg",
                "/images/projects/iiot-dashboard-2.jpg"
            ],
            Featured = true,
            SortOrder = 10
        },
        new()
        {
            Id = "proj-leaktest-integration",
            Slug = "leak-test-barcode-api-integration",
            Title = "Leak Test System Integration with Barcode, Serial Control, and API",
            Category = "Industrial Software",
            ShortSummary = "Integrated barcode scanning, leak testing hardware, and API-driven validation into a unified desktop application for automated quality control and data reporting.",
            Problem = "Leak testing and part validation were disconnected processes, requiring manual interaction, increasing error risk, and limiting real-time visibility.",
            ArchitectureSummary = "Designed a desktop application integrating barcode scanner input, serial communication control for the leak tester, and API-based validation/reporting to create a closed-loop testing workflow.",
            Role = "Led system integration, implemented hardware communication, API interaction, and application logic for automated test execution and data synchronization.",
            TechnicalChallenges = "Reliable serial communication handling, synchronization between hardware states and application logic, and ensuring consistent API data integrity under production conditions.",
            TechStack = ["C#", "Serial Communication", "REST API", "Barcode Scanners"],
            Outcome = "Delivered a unified testing system that improved data accuracy, automated validation, and enabled real-time reporting of test results.",
            Tags = ["Prototype","Integration", "Desktop Application", "Hardware Control", "API", "Quality Control"],
            HeroImage = "/images/projects/leaktest-hero.png",
            GalleryImages = ["/images/projects/leaktest-hero.png"],
            Featured = true,
            SortOrder = 11
        },
        new()
        {
            Id = "proj-scale-barcode-integration",
            Slug = "scale-barcode-api-workflow",
            Title = "Scale, Barcode, and API Integration for Manufacturing Workflow",
            Category = "Industrial Software",
            ShortSummary = "Developed a desktop workflow integrating scale measurement, barcode identification, and API validation for real-time production tracking.",
            Problem = "Manual part identification and weight validation introduced inconsistencies and slowed production flow.",
            ArchitectureSummary = "Built a desktop system that coordinated Ethernet barcode scanning, serial communication with a scale, and API validation to enforce process correctness and data traceability.",
            Role = "Designed and implemented the full integration layer between devices and backend API, including workflow orchestration and operator interaction.",
            TechnicalChallenges = "Coordinating asynchronous device communication (Ethernet + serial), ensuring deterministic workflow execution, and maintaining data consistency across API transactions.",
            TechStack = ["C#", "REST API", "Serial Communication", "Ethernet Devices"],
            Outcome = "Reduced operator errors, improved traceability, and enabled real-time validation of production steps.",
            Tags = ["Delivered","Integration", "Manufacturing", "Traceability", "Desktop Application", "Automation"],
            HeroImage = "/images/projects/scale-hero.png",
            GalleryImages = ["/images/projects/scale-hero.png"],
            Featured = true,
            SortOrder = 12
        }
    ];

    public static readonly IReadOnlyList<SkillCategory> SkillCategories =
    [
        new()
        {
            Name = "Robotics Systems",
            Skills =
            [
                "Robot Cell Architecture & System Layout",
                "Multi-Robot & AMR Integration",
                "EOAT Design, Simulation & Prototyping",
                "Offline Programming & Digital Twin Validation",
                "Vision-Guided Robotics Integration",
                "Structured & Unstructured Bin Picking",
                "Commissioning & Cycle Optimization"
            ]
        },
        new()
        {
            Name = "PLC, HMI & Industrial Controls",
            Skills =
            [
                "PLC/HMI Programming",
                "State-Machine Design & Machine Sequencing",
                "Robot–PLC Handshakes & Orchestration",
                "Industrial I/O & Fieldbus Integration",
                "MES & Traceability Integration",
                "Production Troubleshooting & Line Support",
                "Electrical Design Review & Controls Integration"
            ]
        },
        new()
        {
            Name = "Industrial Networking & Protocols",
            Skills =
            [
                "PLC Communication (Vendor-Agnostic)",
                "MQTT, OPC UA, Modbus TCP, Ethernet/IP",
                "EtherCAT, Profinet, Profibus",
                "REST APIs, TCP/IP & Serial Communication",
                "Real-Time & Asynchronous Data Systems",
                "Custom Drivers & Middleware"
            ]
        },
        new()
        {
            Name = "Embedded & Edge Systems",
            Skills =
            [
                "Embedded Linux System Deployment",
                "Jetson SOM Provisioning & Optimization",
                "BSP Customization & Edge Compute Optimization",
                "Automated Flashing & Update Pipelines",
                "Raspberry Pi Field Updater Hardware",
                "Deployment Utilities & Field Update Tooling"
            ]
        },
        new()
        {
            Name = "Machine Vision",
            Skills =
            [
                "Vision-Guided Robotics Integration",
                "2D/3D Vision & IRVision Workflows",
                "Camera Calibration & Coordinate Systems",
                "Inspection Systems & Validation Workflows",
                "Production Vision Debugging & Optimization"
            ]
        },
        new()
        {
            Name = "Industrial Software & IIoT",
            Skills =
            [
                "C#/.NET (Blazor, ASP.NET Core API, Web API, WinForms)",
                "Python, PowerShell, Bash",
                "Backend Services & Industrial APIs",
                "Machine Data Collection & Traceability",
                "KPI Dashboards & Production Monitoring",
                "Scalable Production Intelligence Systems",
                "OT ↔ IT System Integration"
            ]
        },
        new()
        {
            Name = "Databases & Data Architecture",
            Skills =
            [
                "SQL Server & Azure SQL",
                "Database Schema Design",
                "Production Data Modeling",
                "Multi-Site Data Integration",
                "Traceability Data Pipelines",
                "Operational Data Architecture"
            ]
        },
        new()
        {
            Name = "AI-Assisted Industrial Systems",
            Skills =
            [
                "MCP Server for TwinCAT ADS Integration",
                "Structured PLC Data Access for AI Tools",
                "Offline LLM Workflows for Machine Data Interpretation",
                "Tool-Driven AI Interaction (Read, Inspect, Analyze)",
                "AI-Assisted Diagnostics & System Understanding"
            ]
        },
        new()
        {
            Name = "OT-IT Architecture & Systems Integration",
            Skills =
            [
                "Industrial Data Platform Design",
                "Edge-to-Enterprise Data Flow",
                "Multi-Site System Integration",
                "Protocol Abstraction & Middleware Design",
                "System Interface Definition",
                "Production Diagnostics & Data Architecture"
            ]
        },
        new()
        {
            Name = "Tools & Platforms",
            Skills =
            [
                "TwinCAT 3, Siemens TIA Portal, Studio 5000",
                "Omron, Mitsubishi, Unitronics",
                "FANUC, Epson, Universal Robots, ROBOGUIDE",
                "Cognex, Keyence, OpenCV",
                "Ignition, Grafana",
                "Linux, Git",
                "NVIDIA Jetson, Raspberry Pi"
            ]
        }
    ];

    public static readonly IReadOnlyList<NavItem> NavItems =
    [
        new() { Title = "Home", Href = "/", IconName = "home" },
        new() { Title = "About", Href = "/about", IconName = "user" },
        new() { Title = "Projects", Href = "/projects", IconName = "folder" },
        new() { Title = "Skills", Href = "/skills", IconName = "layers" },
        new() { Title = "Resume", Href = "/resume", IconName = "file" },
        new() { Title = "Contact", Href = "/contact", IconName = "mail" }
    ];
}
