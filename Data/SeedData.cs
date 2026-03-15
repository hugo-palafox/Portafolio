using Portafolio.Models;

namespace Portafolio.Data;

public static class SeedData
{
    public static readonly HomeContent Home = new()
    {
        Name = "Hugo Palafox",
        Headline = "Industrial Systems Architect",
        Subheadline = "Robotics, Controls, Embedded Linux, and OT-IT Integration",
        Description = "I design and deploy industrial automation systems that connect robotics, PLCs, embedded edge devices, vision systems, and software into scalable production-ready architectures.",
        Pillars =
        [
            new() { Title = "Robotics & Digital Twin", Description = "Cell-level robot architecture, simulation validation, and commissioning workflows that reduce integration risk before deployment.", IconName = "bot" },
            new() { Title = "Controls & Machine Integration", Description = "PLC state-machine design, interlock strategy, and I/O abstraction for reliable machine orchestration.", IconName = "cpu" },
            new() { Title = "Embedded Edge Systems", Description = "Edge compute infrastructure for vision and industrial data acquisition with reproducible deployment paths.", IconName = "chip" },
            new() { Title = "Industrial Software & OT-IT Architecture", Description = "Production software services that bridge cell-floor controls with operational and enterprise systems.", IconName = "network" }
        ],
        Metrics =
        [
            new() { Value = "10+ Years", Label = "Automation and controls delivery experience" },
            new() { Value = "40% Risk Reduction", Label = "Deployment risk reduced through digital twin validation" },
            new() { Value = "Edge at Scale", Label = "High-throughput embedded update and rollout workflows" },
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
            ShortSummary = "Designed a replenishment robot cell architecture integrating robot motion plans, PLC coordination, and warehouse material triggers.",
            Problem = "Manual replenishment created line interruptions and uneven takt performance under mixed SKU demand.",
            ArchitectureSummary = "The architecture coupled robot task orchestration, PLC handshakes, and event-driven replenishment triggers from MES-aligned inventory services.",
            Role = "Owned system architecture, PLC/robot interface definitions, and commissioning strategy.",
            TechnicalChallenges = "Cross-vendor timing variance, interlock safety behavior during fault recovery, and deterministic handoff at conveyor boundaries.",
            TechStack = ["Fanuc", "TwinCAT", "OPC UA", "C#", "PostgreSQL"],
            Outcome = "Reduced replenishment latency and stabilized line-side buffer levels with predictable recovery routines.",
            LessonsLearned = "Early interface contracts between controls and software removed late-stage integration churn.",
            Tags = ["Robot Cell", "PLC Integration", "Material Flow"],
            HeroImage = "/images/projects/replenishment-hero.jpg",
            GalleryImages = ["/images/projects/replenishment-1.jpg", "/images/projects/replenishment-2.jpg"],
            Featured = true,
            SortOrder = 1
        },
        new()
        {
            Id = "proj-eoat",
            Slug = "eoat-simulation-to-reality-workflow",
            Title = "EOAT Design and Simulation-to-Reality Workflow",
            Category = "Robotics",
            ShortSummary = "Established an EOAT validation pipeline from CAD simulation through commissioning to reduce on-floor iteration loops.",
            Problem = "End-of-arm tooling revisions during launch drove repeated downtime and delayed production acceptance.",
            ArchitectureSummary = "Created a traceable toolchain connecting mechanical revisions, simulation scenarios, and controls acceptance criteria.",
            Role = "Led cross-functional interface between mechanical, controls, and robot programming teams.",
            TechnicalChallenges = "Maintaining simulation fidelity with real payload behavior and tolerance stack variation.",
            TechStack = ["RoboDK", "SolidWorks", "TwinCAT", "Git", "Python"],
            Outcome = "Increased first-pass EOAT acceptance and reduced launch-phase tooling rework.",
            LessonsLearned = "Simulation quality depends on disciplined parameter baselining, not only geometry fidelity.",
            Tags = ["Digital Twin", "EOAT", "Launch Readiness"],
            HeroImage = "/images/projects/eoat-hero.jpg",
            GalleryImages = ["/images/projects/eoat-1.jpg", "/images/projects/eoat-2.jpg"],
            Featured = true,
            SortOrder = 2
        },
        new()
        {
            Id = "proj-otd",
            Slug = "otd-calibration-ecosystem",
            Title = "OTD Calibration Ecosystem",
            Category = "Machine Vision",
            ShortSummary = "Built a calibration framework for vision-guided operations with repeatable device-level calibration provenance.",
            Problem = "Calibration drift across stations caused accuracy loss and inconsistent downstream quality checks.",
            ArchitectureSummary = "Implemented station calibration services, controlled versioning of calibration artifacts, and runtime validation checks.",
            Role = "Defined calibration architecture and integration contracts with controls and quality systems.",
            TechnicalChallenges = "Device variance, calibration lifecycle governance, and robust rollback during failed calibration runs.",
            TechStack = ["OpenCV", "C#", "Linux", "TwinCAT", "REST APIs"],
            Outcome = "Improved vision stability and reduced quality escapes linked to calibration drift.",
            LessonsLearned = "Calibration ownership and artifact governance are as critical as algorithm precision.",
            Tags = ["Vision", "Calibration", "Quality Systems"],
            HeroImage = "/images/projects/otd-hero.jpg",
            GalleryImages = ["/images/projects/otd-1.jpg", "/images/projects/otd-2.jpg"],
            Featured = true,
            SortOrder = 3
        },
        new()
        {
            Id = "proj-jetson",
            Slug = "jetson-som-deployment-infrastructure",
            Title = "Jetson SOM Deployment Infrastructure",
            Category = "Embedded Edge",
            ShortSummary = "Designed fleet provisioning and update workflow for Jetson-based industrial edge nodes used in vision and analytics workloads.",
            Problem = "Manual image provisioning and drifted runtime dependencies made edge deployments difficult to scale safely.",
            ArchitectureSummary = "Standardized base images, package channels, deployment manifests, and health validation for staged rollouts.",
            Role = "Owned deployment architecture and Linux edge runtime standards.",
            TechnicalChallenges = "Version compatibility across GPU runtime stacks, network-constrained updates, and rollback reliability.",
            TechStack = ["Jetson", "Ubuntu", "Docker", "Ansible", "GitHub Actions"],
            Outcome = "Enabled repeatable edge releases with reduced field rework and faster commissioning cycles.",
            LessonsLearned = "Operational discipline in release channels prevents most edge regressions.",
            Tags = ["Edge Linux", "Deployment", "GPU Runtime"],
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
            ShortSummary = "Defined orchestration and traffic-control interfaces for AMR/AGV fleet integration with fixed automation assets.",
            Problem = "Material flow contention between mobile platforms and fixed stations created throughput uncertainty.",
            ArchitectureSummary = "Implemented a transport request broker, zone control logic, and PLC gateways for synchronized handoff points.",
            Role = "Architected integration patterns between fleet manager, controls layer, and production scheduling signals.",
            TechnicalChallenges = "Deadlock avoidance, multi-zone arbitration, and deterministic docking synchronization.",
            TechStack = ["MQTT", "TwinCAT", "REST APIs", "Redis", "Linux"],
            Outcome = "Improved transport predictability and reduced route conflicts in high-mix scenarios.",
            LessonsLearned = "Zone-level observability is mandatory before tuning dispatch policies.",
            Tags = ["AMR", "AGV", "Traffic Orchestration"],
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
            ShortSummary = "Built a production-safe data interface between PLC machine states and AI inference services at the edge.",
            Problem = "AI models lacked deterministic machine context and generated outputs that were difficult to operationalize.",
            ArchitectureSummary = "Designed a contract-based interface exposing machine state transitions, command gating, and inference result validation.",
            Role = "Defined OT-IT boundaries and implemented controls-safe integration behavior.",
            TechnicalChallenges = "Latency envelopes, command authority boundaries, and fail-safe degradation paths.",
            TechStack = ["TwinCAT", "gRPC", "C#", "Python", "Docker"],
            Outcome = "Enabled trustworthy AI-assisted decisions without violating controls determinism.",
            LessonsLearned = "Safety boundaries must be designed before model integration, not after.",
            Tags = ["AI Interface", "PLC", "Edge Inference"],
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
            ShortSummary = "Created an edge data platform consolidating PLC, vision, and machine telemetry into a consistent operational model.",
            Problem = "Data fragmentation across systems blocked root-cause analysis and slowed engineering feedback loops.",
            ArchitectureSummary = "Implemented protocol adapters, stream normalization, and event persistence with API access for plant applications.",
            Role = "Led platform architecture and integration roadmap across controls and software teams.",
            TechnicalChallenges = "Schema evolution, site-to-site protocol variation, and resilient buffering during network disruption.",
            TechStack = ["OPC UA", "MQTT", "C#", "TimescaleDB", "Grafana"],
            Outcome = "Improved engineering observability and reduced troubleshooting cycle time in production support.",
            LessonsLearned = "Data contracts and observability standards should be treated as first-class platform interfaces.",
            Tags = ["Data Platform", "OT-IT", "Observability"],
            HeroImage = "/images/projects/datahub-hero.jpg",
            GalleryImages = ["/images/projects/datahub-1.jpg", "/images/projects/datahub-2.jpg"],
            Featured = true,
            SortOrder = 7
        }
    ];

    public static readonly IReadOnlyList<SkillCategory> SkillCategories =
    [
        new() { Name = "Robotics & Simulation", Skills = ["Robot Cell Architecture", "Offline Programming", "Digital Twin Validation", "Commissioning Strategy"] },
        new() { Name = "Controls & PLCs", Skills = ["TwinCAT PLC Development", "State Machines", "Safety Interlocks", "Industrial I/O Integration"] },
        new() { Name = "Embedded & Edge Systems", Skills = ["Embedded Linux", "Jetson Deployment", "Containerized Edge Services", "Device Lifecycle Management"] },
        new() { Name = "Industrial Software & APIs", Skills = ["C#/.NET", "REST/gRPC Interfaces", "Service Contracts", "Operational Data Services"] },
        new() { Name = "Vision Systems", Skills = ["Camera Integration", "Calibration Workflows", "Defect Inspection Pipelines", "Vision Runtime Validation"] },
        new() { Name = "Architecture & Integration", Skills = ["OT-IT System Design", "Interface Governance", "Failure Mode Design", "Cross-Domain Integration"] },
        new() { Name = "Tools & Platforms", Skills = ["TwinCAT", "Docker", "GitHub Actions", "Grafana", "PostgreSQL", "Redis"] }
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
