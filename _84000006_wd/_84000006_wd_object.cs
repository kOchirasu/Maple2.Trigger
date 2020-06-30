using System;

namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_object {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateStaging(context);

        private class StateStaging : TriggerState {
            internal StateStaging(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818,
                        819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837,
                        838, 839, 840, 841, 842, 843, 844, 845, 846, 847
                    }, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001442}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001443}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001444}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001445}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Interaction", value: 1)) {
                    context.State = new StateUserCount(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUserCount : TriggerState {
            internal StateUserCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9001, arg2: 50, arg3: "GreaterEqual")) {
                    context.State = new StateOver50(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 30, arg3: "GreaterEqual")) {
                    context.State = new StateOver30(context);
                    return;
                }

                if (context.CountUsers(arg1: 9001, arg2: 30, arg3: "Less")) {
                    context.State = new StateUnder30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOver50 : TriggerState {
            internal StateOver50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001442}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001443}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001444}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001445}, arg2: 1);
                context.SetMesh(
                    arg1: new int[] {
                        800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818,
                        819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837,
                        838, 839, 840, 841, 842, 843, 844, 845, 846, 847
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001442}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001443}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001444}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001445}, arg2: 2)) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940046, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940046, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOver30 : TriggerState {
            internal StateOver30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001442}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001443}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001445}, arg2: 1);
                context.SetMesh(
                    arg1: new int[] {
                        800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818,
                        819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837,
                        838, 839, 840, 841, 842, 843, 844, 845, 846, 847
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001442}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001443}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001445}, arg2: 2)) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940045, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940045, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUnder30 : TriggerState {
            internal StateUnder30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60, arg4: false);
                context.SetInteractObject(arg1: new int[] {10001442}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001445}, arg2: 1);
                context.SetMesh(
                    arg1: new int[] {
                        800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818,
                        819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832, 833, 834, 835, 836, 837,
                        838, 839, 840, 841, 842, 843, 844, 845, 846, 847
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001442}, arg2: 2)
                    && context.ObjectInteracted(arg1: new int[] {10001445}, arg2: 2)) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940043, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.AddBuff(arg1: new int[] {9002}, arg2: 99940043, arg3: 1, arg4: false, arg5: true);
                    context.SetUserValue(triggerID: 1001, key: "Steal", value: 1);
                    context.State = new StateStandby(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandby : TriggerState {
            internal StateStandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Interaction", value: 2)) {
                    context.State = new StateInteraction_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteraction_Off : TriggerState {
            internal StateInteraction_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830,
                        831, 832, 833, 834, 835, 836, 837, 838, 839, 840, 841, 842, 843, 844, 845, 846, 847
                    }, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001442}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001443}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001444}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001445}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}