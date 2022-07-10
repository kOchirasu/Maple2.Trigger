namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_object {
        public class StateStaging : TriggerState {
            internal StateStaging(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847}, visible: true);
                context.SetInteractObject(interactIds: new []{10001442, 10001443, 10001444, 10001445}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Interaction") == 1) {
                    return new StateUserCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserCount : TriggerState {
            internal StateUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9001) >= 50) {
                    return new StateOver50(context);
                }

                if (context.GetUserCount(boxId: 9001) >= 30) {
                    return new StateOver30(context);
                }

                if (context.GetUserCount(boxId: 9001) < 30) {
                    return new StateUnder30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOver50 : TriggerState {
            internal StateOver50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 60, display: false);
                context.SetInteractObject(interactIds: new []{10001442, 10001443, 10001444, 10001445}, state: 1);
                context.SetMesh(triggerIds: new []{800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001442}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001443}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001444}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001445}, arg2: 2)) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940046, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940046, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOver30 : TriggerState {
            internal StateOver30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 60, display: false);
                context.SetInteractObject(interactIds: new []{10001442, 10001443, 10001445}, state: 1);
                context.SetMesh(triggerIds: new []{800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001442}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001443}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001445}, arg2: 2)) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940045, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940045, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnder30 : TriggerState {
            internal StateUnder30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 60, display: false);
                context.SetInteractObject(interactIds: new []{10001442, 10001445}, state: 1);
                context.SetMesh(triggerIds: new []{800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001442}, arg2: 2) && context.ObjectInteracted(interactIds: new []{10001445}, arg2: 2)) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940043, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    context.AddBuff(boxIds: new []{9002}, skillId: 99940043, level: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerId: 1001, key: "Steal", value: 1);
                    return new StateStandby(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Interaction") == 2) {
                    return new StateInteraction_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteraction_Off : TriggerState {
            internal StateInteraction_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847}, visible: true);
                context.SetInteractObject(interactIds: new []{10001442, 10001443, 10001444, 10001445}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
