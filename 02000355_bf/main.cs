using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000355_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 299, arg2: true, arg3: "Dead_Idle_A");
                context.CreateMonster(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
                context.SetEffect(arg1: new[] {600, 699}, arg2: false);
                context.SetMesh(arg1: new[] {3999, 3900, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7001}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new[] {699}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State카드반교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반교체 : TriggerState {
            internal State카드반교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 299, arg2: false, arg3: "Dead_Idle_A");
                context.CreateMonster(arg1: new[] {2097}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State카드반Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script01 : TriggerState {
            internal State카드반Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000355_BF__MAIN__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State카트반이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반이동 : TriggerState {
            internal State카트반이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetMesh(arg1: new[] {3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2097, arg2: "MS2PatrolData2097_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(arg1: new[] {3900}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetCinematicUI(arg1: 0);
                    context.SetCinematicUI(arg1: 2);
                    context.CameraSelect(arg1: 301, arg2: false);
                    context.ShowGuideSummary(entityId: 20003552, textId: 20003552, duration: 4000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    return new State카트반소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카트반소멸 : TriggerState {
            internal State카트반소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2099}, arg2: false);
                    context.DestroyMonster(arg1: new[] {2097});
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new StateEndStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndStartCinematic : TriggerState {
            internal StateEndStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State카드반Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카드반Script02 : TriggerState {
            internal State카드반Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000355_BF__MAIN__1$", arg4: 4);
                context.SetSkip(arg1: "StopCinematic2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic2 : TriggerState {
            internal StateStopCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonClear();
                    context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808}, arg2: true, arg3: 0, arg4: 50, arg5: 2f);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}