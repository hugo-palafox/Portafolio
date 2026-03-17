using Portafolio.Models;

namespace Portafolio.Data;

public static class SeedData
{
    public static readonly HomeContent Home = new()
    {
        Name = "Hugo Palafox",
        Headline = "Robotics & Automation Systems Engineer",
        Subheadline = "Robotics Integration, PLC Systems, Embedded Edge Computing, and OT-IT Architecture",
        Description = "I design and deploy industrial automation systems that integrate robotics, PLC controls, embedded edge devices, machine vision, and industrial software into scalable production-ready platforms.",
        Pillars =
        [
            new()
            {
                Title = "Robotics Systems & Digital Twin",
                Description = "Robot cell architecture, simulation validation, and commissioning workflows that reduce integration risk and accelerate deployment.",
                IconName = "bot"
            },
            new()
            {
                Title = "Controls & Machine Orchestration",
                Description = "PLC state-machine design, robot-PLC coordination, and industrial I/O orchestration for reliable machine automation.",
                IconName = "cpu"
            },
            new()
            {
                Title = "Embedded Edge Infrastructure",
                Description = "Edge compute platforms for vision processing, machine telemetry, and reproducible deployment of industrial applications.",
                IconName = "chip"
            },
            new()
            {
                Title = "Industrial Software & OT-IT Integration",
                Description = "Industrial software services that connect machine-level controls with production systems, analytics, and enterprise platforms.",
                IconName = "network"
            }
        ],
        Metrics =
        [
            new() { Value = "10+ Years", Label = "Industrial automation and robotics engineering" },
            new() { Value = "40% Risk Reduction", Label = "Robot deployment risk reduced through digital-twin validation" },
            new() { Value = "20x Faster Updates", Label = "Embedded device rollout through automated flashing workflows" },
            new() { Value = "Multi-Domain Ownership", Label = "Robotics, PLC, embedded, vision, and software integration" }
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
            ShortSummary = "Designed a vision-guided replenishment robotics architecture integrating robot motion, PLC coordination, and dispenser-driven material flow.",
            Problem = "Manual replenishment workflows introduced interruptions, operator dependency, and uneven refill timing across dispensing operations.",
            ArchitectureSummary = "The system architecture combines robot task orchestration, PLC handshakes, machine state logic, and future AMR integration paths to support scalable replenishment automation.",
            Role = "Owned robotics architecture, PLC/robot interface definitions, EOAT direction, and commissioning strategy.",
            TechnicalChallenges = "Robot reachability, compact footprint constraints, interlock behavior during recovery, and deterministic handoff between machine states and robot workflows.",
            TechStack = ["Fanuc", "TwinCAT", "C#", "Industrial Vision"],
            Outcome = "Advanced the replenishment platform toward demonstration stage with validated robot workflows and production-oriented EOAT design.",
            LessonsLearned = "Early alignment between robotics, controls, and software reduces integration churn as the platform scales.",
            Tags = ["Robot Cell", "PLC Integration", "Replenishment"],
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
            ShortSummary = "Built an EOAT validation workflow from CAD and simulation through prototyping and commissioning to reduce launch-phase iteration.",
            Problem = "End-of-arm tooling revisions during launch drove repeated downtime and delayed production acceptance.",
            ArchitectureSummary = "Created a traceable workflow connecting mechanical revisions, simulation scenarios, robot validation, and controls acceptance criteria.",
            Role = "Led the interface between mechanical design, controls, and robot programming teams.",
            TechnicalChallenges = "Maintaining simulation fidelity with real payload behavior, tolerance stack variation, and mechanical revision changes.",
            TechStack = ["Roboguide", "SolidWorks", "TwinCAT", "Python"],
            Outcome = "Improved first-pass EOAT acceptance and reduced launch-phase tooling rework.",
            LessonsLearned = "Simulation quality depends on disciplined parameter baselining, not geometry alone.",
            Tags = ["Digital Twin", "EOAT", "Launch Readiness"],
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

    ShortSummary = "Developed automation tooling and deployment infrastructure to manage embedded system updates, diagnostics, and provisioning across automated dispensing machines.",

    Problem = "Updating embedded systems and machine software across multiple production machines relied on manual procedures, creating deployment delays, operator friction, and risk of configuration drift.",

    ArchitectureSummary = "Designed a unified deployment workflow combining automation scripts, operator-facing utilities, and portable update hardware to standardize embedded system provisioning and machine software updates.",

    Role = "Designed and implemented automation scripts, operator tools, and a portable updater device prototype to simplify deployments and standardize field update procedures.",

    TechnicalChallenges = "Coordinating updates across embedded Linux systems, PLC-connected machines, and operator workflows while maintaining reliability and minimizing machine downtime.",

    TechStack = ["Python", "C#", "PowerShell", "Linux", "Jetson", "Raspberry Pi"],

    Outcome = "Reduced deployment complexity and improved consistency of machine updates by introducing automated workflows and portable field update tooling.",

    LessonsLearned = "Operator-friendly tools and standardized deployment processes significantly reduce operational friction in embedded industrial environments.",

    Tags = ["Embedded Systems", "Deployment Automation", "Operator Tools", "Industrial Software"],

    HeroImage = "/images/projects/updater.png",
    GalleryImages =
    [
        "/images/projects/otd-1.jpg",
        "/images/projects/otd-2.jpg"
    ],

    Featured = true,
    SortOrder = 3
},
        new()
        {
            Id = "proj-jetson",
            Slug = "jetson-som-deployment-infrastructure",
            Title = "Jetson SOM Deployment Infrastructure",
            Category = "Embedded Edge",
            ShortSummary = "Designed deployment and update workflows for Jetson-based industrial edge systems used in vision and automation workloads.",
            Problem = "Manual image provisioning and drifted runtime dependencies made edge deployments difficult to scale safely.",
            ArchitectureSummary = "Standardized images, runtime dependencies, flashing workflows, and health validation paths for more repeatable deployments.",
            Role = "Owned deployment architecture, BSP customization workflows, and edge runtime standards.",
            TechnicalChallenges = "Version compatibility across GPU runtime stacks, network-constrained updates, and rollback reliability.",
            TechStack = ["Jetson", "Ubuntu", "Python", "Bash", "PowerShell"],
            Outcome = "Reduced deployment time and improved reliability of field updates across edge compute systems.",
            LessonsLearned = "Operational discipline in release channels prevents most edge regressions.",
            Tags = ["Edge Linux", "Deployment", "Embedded Updates"],
            HeroImage = "/images/projects/jetson-hero.jpg",
            GalleryImages = ["/images/projects/jetson-1.jpg", "/images/projects/jetson-2.jpg"],
            Featured = true,
            SortOrder = 4
        },
        new()
        {
            Id = "proj-amr",
            Slug = "amr-agv-material-transport-architecture",
            Title = "AMR / AGV Material Transport Architecture",
            Category = "System Architecture",
            ShortSummary = "Defined early integration architecture for AMR/AGV material transport supporting replenishment and machine logistics workflows.",
            Problem = "Material flow between mobile platforms and fixed stations created uncertainty in transport timing, handoff logic, and system scalability.",
            ArchitectureSummary = "Developed concepts for transport orchestration, machine handoff logic, and material flow interfaces between mobile robots and fixed automation assets.",
            Role = "Defined integration concepts between AMR fleet behavior, machine workflows, and future staging logic.",
            TechnicalChallenges = "Docking consistency, traffic coordination, system boundaries between transport and manipulation, and scalable handoff rules.",
            TechStack = ["MQTT", "TwinCAT", "REST APIs", "Linux"],
            Outcome = "Established an architectural foundation for future mobile robotics integration.",
            LessonsLearned = "Transport logic and machine handoff rules must be defined early to avoid scaling complexity later.",
            Tags = ["AMR", "AGV", "Material Flow"],
            HeroImage = "/images/projects/amr-hero.jpg",
            GalleryImages = ["/images/projects/amr-1.jpg", "/images/projects/amr-2.jpg"],
            Featured = true,
            SortOrder = 5
        },
        new()
        {
            Id = "proj-plc-ai",
            Slug = "plc-to-ai-machine-interface",
            Title = "PLC-to-AI Machine Interface",
            Category = "OT-IT Integration",
            ShortSummary = "Built a proof-of-concept interface enabling AI tools to consume PLC machine states for diagnostics and engineering assistance.",
            Problem = "AI tools lacked structured machine context, making it difficult to explore meaningful industrial use cases.",
            ArchitectureSummary = "Designed an interface exposing machine states and controlled data access while preserving controls-layer boundaries.",
            Role = "Defined OT-IT boundaries and implemented proof-of-concept PLC-to-AI integration behavior.",
            TechnicalChallenges = "Latency, machine context consistency, and safe separation between controls and AI-assisted workflows.",
            TechStack = ["TwinCAT", "C#", "Python", "MCP"],
            Outcome = "Validated a practical path for AI-assisted diagnostics using structured PLC context.",
            LessonsLearned = "Machine context and safety boundaries must be defined clearly before AI integration becomes useful.",
            Tags = ["AI Interface", "PLC", "Diagnostics"],
            HeroImage = "/images/projects/plc-ai-hero.jpg",
            GalleryImages = ["/images/projects/plc-ai-1.jpg", "/images/projects/plc-ai-2.jpg"],
            Featured = true,
            SortOrder = 6
        },
        new()
        {
            Id = "proj-datahub",
            Slug = "industrial-data-hub-edge-platform",
            Title = "Industrial Data Hub Edge Platform",
            Category = "Industrial Software",
            ShortSummary = "Designed an industrial data platform concept consolidating PLC, vision, and machine telemetry into a unified operational model.",
            Problem = "Data fragmentation across systems blocked root-cause analysis and slowed engineering feedback loops.",
            ArchitectureSummary = "Combined protocol adapters, normalized machine data, and application-layer services to support dashboards, diagnostics, and engineering visibility.",
            Role = "Defined data integration patterns across controls, software, and operational reporting systems.",
            TechnicalChallenges = "Schema evolution, protocol variation across equipment, and resilient buffering during network disruption.",
            TechStack = ["MQTT", "C#", "SQL Server", "Grafana"],
            Outcome = "Improved engineering observability and reduced troubleshooting cycle time in production support.",
            LessonsLearned = "Data contracts and observability standards should be treated as first-class platform interfaces.",
            Tags = ["Data Platform", "OT-IT", "Observability"],
            HeroImage = "/images/projects/datahub-hero.jpg",
            GalleryImages = ["/images/projects/datahub-1.jpg", "/images/projects/datahub-2.jpg"],
            Featured = true,
            SortOrder = 7
        },
        new()
        {
            Id = "proj-ultrasonic-welding",
            Slug = "automation-ultrasonic-welding-robot-dual-zone",
            Title = "Ultrasonic Welding Automation with 6-Axis Robot and Dual-Zone Cell",
            Category = "Robotics",
            ShortSummary = "Led end-to-end conversion of a manual ultrasonic welding process into a fully automated dual-zone robotic system with PLC integration and staged startup.",
            Problem = "Manual ultrasonic welding introduced throughput variability, labor dependency, and inconsistent quality under production demand.",
            ArchitectureSummary = "Designed a dual-zone architecture with 6-axis robotic operations, PLC-coordinated sequencing, and synchronized zone handoffs to maintain continuous output.",
            Role = "Owned concept architecture, component sourcing, robot and PLC programming, build execution, integration, and startup.",
            TechnicalChallenges = "Balancing cycle-time targets with safe multi-zone robot coordination, commissioning without disrupting production, and ensuring stable process repeatability.",
            TechStack = ["6-Axis Robots", "PLC Controls", "HMI", "Industrial I/O", "Ultrasonic Welding"],
            Outcome = "Increased production efficiency, reduced labor cost, and improved process consistency with minimal deployment disruption.",
            LessonsLearned = "Early sequencing and interface definitions between robot, PLC, and zone logic significantly reduce startup risk in retrofit automation projects.",
            Tags = ["Robot Welding", "Dual-Zone Cell", "PLC Integration", "Automation Retrofit"],
            HeroImage = "/images/projects/dual-zone-robot-welding-cell.jpg",
            GalleryImages =
            [
                "/images/projects/robot-welding-cell-1.jpg",
                "/images/projects/robot-welding-cell-2.jpg",
                "/images/projects/robot-welding-cell-4.jpg"
            ],
            Featured = true,
            SortOrder = 8
        },
        new()
{
    Id = "proj-iiot-dashboard",
    Slug = "industrial-iot-dashboard-platform",
    Title = "Industrial IoT Platform for Multi-Site PLC Data Integration",
    Category = "Industrial Software",

    ShortSummary = "Designed and deployed a full-stack IIoT platform from scratch, integrating multi-brand PLC data across distributed machines into a unified dashboard and data infrastructure.",

    Problem = "Existing solutions required ~$1,000 per machine annually plus ~$8,000 upfront hardware and integration costs, limiting scalability and preventing full visibility across equipment—especially in sites with limited or no network infrastructure.",

    ArchitectureSummary = "Developed an end-to-end IIoT architecture including custom PLC data drivers, edge data collection nodes, local database deployment, and centralized dashboard services. Designed flexible network solutions using mini PCs, compute sticks, and dedicated routers to support machines with limited connectivity, along with optional cloud database prototypes for remote monitoring.",

    Role = "Owned the full system lifecycle including PLC driver development, data acquisition strategy, database design, network architecture, hardware selection, deployment planning, and multi-site rollout coordination.",

    TechnicalChallenges = "Developing reliable data drivers across different PLC platforms, handling machines with no network access, ensuring stable data collection, designing scalable database structures, and coordinating deployments across multiple sites and teams.",

    TechStack = ["C#", ".NET", "SQL Server", "Python", "TCP/Serial", "Industrial Networking", "PLC Integration"],

    Outcome = "Deployed across 24 machines (20 local, 4 out-of-state), eliminating recurring subscription costs and significantly reducing hardware and integration expenses while expanding full system visibility across all equipment.",

    LessonsLearned = "Owning the full stack—from PLC data acquisition to deployment infrastructure—enables scalable, cost-effective industrial systems and allows flexibility in constrained network environments.",

    Tags = ["IIoT", "PLC Integration", "Edge Systems", "Industrial Software", "Multi-Site Deployment"],

    HeroImage = "/images/projects/iiot-dashboard-hero.jpg",
    GalleryImages =
    [
        "/images/projects/iiot-dashboard-1.jpg",
        "/images/projects/iiot-dashboard-2.jpg"
    ],

    Featured = true,
    SortOrder = 9
}
    ];

    public static readonly IReadOnlyList<SkillCategory> SkillCategories =
    [
        new() { Name = "Robotics Systems", Skills = ["Robot Cell Architecture", "Offline Programming", "Digital Twin Validation", "EOAT Integration"] },
        new() { Name = "PLC & Controls", Skills = ["TwinCAT PLC Development", "State Machines", "Robot-PLC Coordination", "Industrial I/O Integration"] },
        new() { Name = "Embedded Systems", Skills = ["Embedded Linux", "Jetson SOM Deployment", "Edge Device Provisioning", "Firmware Update Pipelines"] },
        new() { Name = "Industrial Software", Skills = ["C#/.NET", "REST APIs", "Service Architecture", "Machine Data Platforms"] },
        new() { Name = "Machine Vision", Skills = ["Camera Integration", "Calibration Workflows", "Inspection Systems", "Vision-Guided Robotics"] },
        new() { Name = "System Architecture", Skills = ["OT-IT Integration", "Automation Platforms", "Failure Mode Design", "Cross-Domain Integration"] },
        new() { Name = "Tools & Platforms", Skills = ["TwinCAT", "Grafana", "SQL Server", "MQTT", "Linux", "Git"] }
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
