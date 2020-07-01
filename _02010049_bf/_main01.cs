using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010049_bf {
    public static class _main01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetMesh(arg1: new[] {10000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 20000, 30000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 9990, 9991, 9992, 9993, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102, 103, 104, 105, 107, 108, 201, 202, 203, 204, 205, 206}, arg2: false);
                context.ShowGuideSummary(entityId: 20104901, textId: 20104901, duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "CameraWalk02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9990, 9991, 9992, 9993}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State전투지역01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역01시작 : TriggerState {
            internal State전투지역01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102, 103, 104, 105, 107, 108})) {
                    return new State전투지역02대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02대기 : TriggerState {
            internal State전투지역02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104903, textId: 20104903, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State전투지역02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02시작 : TriggerState {
            internal State전투지역02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State전투지역02추가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역02추가 : TriggerState {
            internal State전투지역02추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104904, textId: 20104904, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206})) {
                    return new State전투지역03대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역03대기 : TriggerState {
            internal State전투지역03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {20000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104903, textId: 20104903, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new State전투지역03시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역03시작 : TriggerState {
            internal State전투지역03시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {399, 302, 303, 304, 305, 306, 307, 309}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104902, textId: 20104902, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {302, 303, 304, 305, 306, 307})) {
                    return new State전투지역04시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투지역04시작 : TriggerState {
            internal State전투지역04시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 20104904, textId: 20104904, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {309})) {
                    return new State퇴장연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장연출01 : TriggerState {
            internal State퇴장연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {399});
                context.CreateMonster(arg1: new[] {400}, arg2: false);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_399");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State퇴장연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장연출02 : TriggerState {
            internal State퇴장연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State퇴장연출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장연출03 : TriggerState {
            internal State퇴장연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 8000, arg2: new[] {400})) {
                    return new State다리생성01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리생성01 : TriggerState {
            internal State다리생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {400});
                context.SetMesh(arg1: new[] {30000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(arg1: new[] {7000, 7001, 7002, 7003}, arg2: true, arg3: 4, arg4: 100, arg5: 100);
                context.ShowGuideSummary(entityId: 20104905, textId: 20104905, duration: 6000);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9010})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}