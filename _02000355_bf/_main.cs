using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000355_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 299, arg2: true, arg3: "Dead_Idle_A");
                context.CreateMonster(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
                context.SetEffect(arg1: new[] {600, 699}, arg2: false);
                context.SetMesh(arg1: new[] {3999, 3900, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713, 3714, 3715, 3716}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7001}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetEffect(arg1: new[] {699}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State카드반교체(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반교체 : TriggerState {
            internal State카드반교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 299, arg2: false, arg3: "Dead_Idle_A");
                context.CreateMonster(arg1: new[] {2097}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카드반대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사01 : TriggerState {
            internal State카드반대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000355_BF__MAIN__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카트반이동(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2097, arg2: "MS2PatrolData2097_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(arg1: new[] {3900}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.CameraSelect(arg1: 301, arg2: false);
                    context.ShowGuideSummary(entityId: 20003552, textId: 20003552, duration: 4000);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.State = new State카트반소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반소멸 : TriggerState {
            internal State카트반소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2099}, arg2: false);
                    context.DestroyMonster(arg1: new[] {2097});
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    context.State = new State종료연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료연출시작 : TriggerState {
            internal State종료연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State카드반대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카드반대사02 : TriggerState {
            internal State카드반대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 24001705, arg3: "$02000355_BF__MAIN__1$", arg4: 4);
                context.SetSkip(arg1: "연출종료2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료2 : TriggerState {
            internal State연출종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonClear();
                    context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804, 3805, 3806, 3807, 3808}, arg2: true, arg3: 0, arg4: 50, arg5: 2f);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}