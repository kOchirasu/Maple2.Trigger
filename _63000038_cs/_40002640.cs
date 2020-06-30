using System;

namespace Maple2.Trigger._63000038_cs {
    public static class _40002640 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3400}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSound(arg1: 13500, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.State = new State퀘스트분기_스트라이커(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 110)) {
                    context.State = new State퀘스트분기_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트분기_스트라이커 : TriggerState {
            internal State퀘스트분기_스트라이커(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002640},
                    arg3: new byte[] {1})) {
                    context.State = new State1차연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002640},
                    arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    context.State = new State40002641수락대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002640},
                    arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    context.State = new State40002641수락대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002641},
                    arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트분기_소울바인더 : TriggerState {
            internal State퀘스트분기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002650},
                    arg3: new byte[] {1})) {
                    context.State = new State1차연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002650},
                    arg3: new byte[] {2})) {
                    context.State = new State1차연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002650},
                    arg3: new byte[] {3})) {
                    context.State = new State1차연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {40002651},
                    arg3: new byte[] {1})) {
                    context.State = new State1차연출시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002651},
                    arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    context.State = new State40002651완료가능(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002651},
                    arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    context.State = new State40002651완료가능(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002652},
                    arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002652},
                    arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차연출시작 : TriggerState {
            internal State1차연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2001, arg2: "Attack_Idle_A", arg3: 9999999999f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    context.State = new State1차연출딜레이(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 110)) {
                    context.CreateMonster(arg1: new int[] {11001}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 11001, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    context.State = new State1차연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차연출딜레이 : TriggerState {
            internal State1차연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "1차연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State1차연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차연출종료 : TriggerState {
            internal State1차연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.CreateMonster(arg1: new int[] {2101, 2102}, arg2: false);
                context.SetUserValue(triggerID: 99999002, key: "Setlever", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2101})) {
                    context.State = new State계단생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2102})) {
                    context.State = new State계단생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단생성 : TriggerState {
            internal State계단생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2001});
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                context.DestroyMonster(arg1: new int[] {2101, 2102});
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.State = new State2차전투대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투대기 : TriggerState {
            internal State2차전투대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 1002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    context.State = new State2차전투(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 110)) {
                    context.DestroyMonster(arg1: new int[] {11001});
                    context.CreateMonster(arg1: new int[] {11002}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 11002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    context.State = new State2차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2103}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2103})) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3400}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103", arg2: 100)) {
                    context.State = new State2차연출시작(context);
                    return;
                }

                if (context.UserDetected(arg1: "103", arg2: 110)) {
                    context.State = new State2차연출시작_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차연출시작 : TriggerState {
            internal State2차연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State칸두라대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사01 : TriggerState {
            internal State칸두라대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__0$", arg4: 3);
                context.SetSkip(arg1: "칸두라대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State칸두라대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사01스킵 : TriggerState {
            internal State칸두라대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사02 : TriggerState {
            internal State칸두라대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__1$", arg4: 5);
                context.SetSkip(arg1: "칸두라대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State칸두라공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사02스킵 : TriggerState {
            internal State칸두라대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라공격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라공격 : TriggerState {
            internal State칸두라공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State칸두라공격이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라공격이펙트 : TriggerState {
            internal State칸두라공격이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State가로막기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가로막기 : TriggerState {
            internal State가로막기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State처맞기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처맞기 : TriggerState {
            internal State처맞기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State처맞기후딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처맞기후딜레이 : TriggerState {
            internal State처맞기후딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetNpcEmotionLoop(arg1: 1002, arg2: "Down_Idle_A", arg3: 9999999999f);
                    context.State = new StateNPC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001782, arg3: "$63000038_CS__40002640__2$", arg4: 3);
                context.SetSkip(arg1: "NPC대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01스킵 : TriggerState {
            internal StateNPC대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001782, arg3: "$63000038_CS__40002640__3$", arg4: 4);
                context.SetSkip(arg1: "NPC대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State칸두라대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02스킵 : TriggerState {
            internal StateNPC대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사03 : TriggerState {
            internal State칸두라대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__4$", arg4: 5);
                context.SetSkip(arg1: "칸두라대사03스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State칸투라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사03스킵 : TriggerState {
            internal State칸두라대사03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸투라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차연출시작_소울바인더 : TriggerState {
            internal State2차연출시작_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State칸두라대사01_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사01_소울바인더 : TriggerState {
            internal State칸두라대사01_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__5$", arg4: 4);
                context.SetSkip(arg1: "칸두라대사01스킵_소울바인더");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State칸두라대사02_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사01스킵_소울바인더 : TriggerState {
            internal State칸두라대사01스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사02_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사02_소울바인더 : TriggerState {
            internal State칸두라대사02_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__6$", arg4: 4);
                context.SetSkip(arg1: "칸두라대사02스킵_소울바인더");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State칸두라공격_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사02스킵_소울바인더 : TriggerState {
            internal State칸두라대사02스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라공격_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라공격_소울바인더 : TriggerState {
            internal State칸두라공격_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State칸두라공격이펙트_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라공격이펙트_소울바인더 : TriggerState {
            internal State칸두라공격이펙트_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {600}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State가로막기_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가로막기_소울바인더 : TriggerState {
            internal State가로막기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 11002, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State처맞기_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처맞기_소울바인더 : TriggerState {
            internal State처맞기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 11002, arg2: "MS2PatrolData_1002B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State처맞기후딜레이_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State처맞기후딜레이_소울바인더 : TriggerState {
            internal State처맞기후딜레이_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetNpcEmotionLoop(arg1: 11002, arg2: "Down_Idle_A", arg3: 9999999999f);
                    context.State = new State칸두라대사03_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사03_소울바인더 : TriggerState {
            internal State칸두라대사03_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__7$", arg4: 3);
                context.SetSkip(arg1: "칸두라대사03스킵_소울바인더");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State칸두라대사04_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사03스킵_소울바인더 : TriggerState {
            internal State칸두라대사03스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사04_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사04_소울바인더 : TriggerState {
            internal State칸두라대사04_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__8$", arg4: 6);
                context.SetSkip(arg1: "칸두라대사04스킵_소울바인더");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State칸투라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사04스킵_소울바인더_소울바인더 : TriggerState {
            internal State칸두라대사04스킵_소울바인더_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸투라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸투라이동 : TriggerState {
            internal State칸투라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2104, 2105}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2차연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차연출종료 : TriggerState {
            internal State2차연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 305, arg2: false);
                context.DestroyMonster(arg1: new int[] {2002});
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "FirstPhaseEnd", value: 1)) {
                    context.SetMesh(arg1: new int[] {3401}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetActor(arg1: 202, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
                    context.State = new State3차연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차연출시작 : TriggerState {
            internal State3차연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {2104, 2105});
                context.CameraSelect(arg1: 306, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State3차연출분기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차연출분기 : TriggerState {
            internal State3차연출분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.State = new State3차연출종료(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 110)) {
                    context.State = new StateNPC교체_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체_소울바인더 : TriggerState {
            internal StateNPC교체_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "KillallShadow");
                context.DestroyMonster(arg1: new int[] {11002});
                context.CreateMonster(arg1: new int[] {11003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State3차연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차연출종료 : TriggerState {
            internal State3차연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99999004, key: "BossGuide", value: 1);
                context.CameraSelect(arg1: 307, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "ChangeBGM", value: 1)) {
                    context.State = new StateHP50퍼센트대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHP50퍼센트대기 : TriggerState {
            internal StateHP50퍼센트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "CallFriendlyNPC", value: 1)) {
                    context.State = new State4차소환분기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차소환분기 : TriggerState {
            internal State4차소환분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.DestroyMonster(arg1: new int[] {1002});
                    context.CreateMonster(arg1: new int[] {1003}, arg2: true);
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002651},
                    arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new int[] {11003});
                    context.CreateMonster(arg1: new int[] {11004}, arg2: true);
                    context.State = new StateNPC소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BattleEnd", value: 1)) {
                    context.State = new StateNPC원위치딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치딜레이 : TriggerState {
            internal StateNPC원위치딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State5차원위치분기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5차원위치분기 : TriggerState {
            internal State5차원위치분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "199", arg2: 100)) {
                    context.State = new StateNPC원위치(context);
                    return;
                }

                if (context.UserDetected(arg1: "199", arg2: 110)) {
                    context.State = new StateNPC원위치_소울바인더(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치 : TriggerState {
            internal StateNPC원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new int[] {1003})) {
                    context.State = new State40002641수락대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State40002641수락대기 : TriggerState {
            internal State40002641수락대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1003});
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002641},
                    arg3: new byte[] {1})) {
                    context.State = new State포털생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치_소울바인더 : TriggerState {
            internal StateNPC원위치_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 11004, arg2: "MS2PatrolData_1003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new int[] {11004})) {
                    context.State = new State소울바인더연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소울바인더연출시작 : TriggerState {
            internal State소울바인더연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 63000038, arg2: 3);
                context.DestroyMonster(arg1: new int[] {11004});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State준타틴차이등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타틴차이등장 : TriggerState {
            internal State준타틴차이등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {13001, 13002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000038_CS__40002640__9$", arg4: 5);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State칸두라대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사05 : TriggerState {
            internal State칸두라대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 311, arg2: true);
                context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2004, arg2: "Attack_Idle_A", arg3: 9999999999f);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__10$", arg4: 5);
                context.SetSkip(arg1: "칸두라대사05스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State칸두라대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사05스킵 : TriggerState {
            internal State칸두라대사05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State칸두라대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사06 : TriggerState {
            internal State칸두라대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__11$", arg4: 3);
                context.SetSkip(arg1: "칸두라대사06스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State비전등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라대사06스킵 : TriggerState {
            internal State칸두라대사06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State비전등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비전등장 : TriggerState {
            internal State비전등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 309, arg2: true);
                context.CreateMonster(arg1: new int[] {14001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State칸두라공격02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칸두라공격02 : TriggerState {
            internal State칸두라공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2004, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State비전대신맞기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비전대신맞기 : TriggerState {
            internal State비전대신맞기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State비전대신맞기이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비전대신맞기이펙트 : TriggerState {
            internal State비전대신맞기이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State동영상시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동영상시작 : TriggerState {
            internal State동영상시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Farewell_Vision.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State40002651완료가능(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "DisappearKandura");
            }
        }

        private class State40002651완료가능 : TriggerState {
            internal State40002651완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {13001, 13002, 14001, 2004});
                context.CreateMonster(arg1: new int[] {13003, 13004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002652},
                    arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {40002652},
                    arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 26300381, textID: 26300381, durationTime: 3000);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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