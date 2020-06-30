using System;

namespace Maple2.Trigger._02000535_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {801}, arg2: false);
                context.SetEffect(arg1: new int[] {802}, arg2: false);
                context.SetMesh(arg1: new int[] {4002}, arg2: true);
                context.SetMesh(arg1: new int[] {4003}, arg2: true);
                context.SetMesh(arg1: new int[] {4004}, arg2: true);
                context.SetMesh(arg1: new int[] {4005}, arg2: true);
                context.SetMesh(arg1: new int[] {4006}, arg2: true);
                context.SetMesh(arg1: new int[] {4007}, arg2: true);
                context.SetMesh(arg1: new int[] {4008}, arg2: true);
                context.SetMesh(arg1: new int[] {4009}, arg2: true);
                context.SetMesh(arg1: new int[] {4010}, arg2: true);
                context.SetMesh(arg1: new int[] {4011}, arg2: true);
                context.SetMesh(arg1: new int[] {4012}, arg2: true);
                context.SetMesh(arg1: new int[] {4013}, arg2: true);
                context.SetMesh(arg1: new int[] {4014}, arg2: true);
                context.SetMesh(arg1: new int[] {4015}, arg2: true);
                context.SetMesh(arg1: new int[] {4016}, arg2: true);
                context.SetMesh(arg1: new int[] {4017}, arg2: true);
                context.SetMesh(arg1: new int[] {4018}, arg2: true);
                context.SetMesh(arg1: new int[] {4019}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10003145}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003146}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003136}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003137}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701", arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {5522, 5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530},
                    arg2: true);
                context.CreateMonster(arg1: new int[] {9902, 9903, 9904, 9905}, arg2: true);
                context.CreateMonster(
                    arg1: new int[] {
                        5500, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5513, 5514, 5515,
                        5516, 5517, 5518, 5519, 5520, 5521
                    }, arg2: true);
                context.CreateMonster(
                    arg1: new int[] {506, 507, 508, 509, 510, 511, 512, 513, 519, 518, 517, 516, 515, 514, 670, 671},
                    arg2: true);
                context.CreateMonster(arg1: new int[] {5532}, arg2: true);
                context.MoveNpc(arg1: 5532, arg2: "MS2PatrolData_8000");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {5531}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 5531, msg: "$02000535_BF__MAIN__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 5531, msg: "$02000535_BF__MAIN__1$", duration: 3500,
                    delayTick: 3500);
                context.AddBalloonTalk(spawnPointID: 5523, msg: "$02000535_BF__MAIN__2$", duration: 3500,
                    delayTick: 4500);
                context.AddBalloonTalk(spawnPointID: 5530, msg: "$02000535_BF__MAIN__3$", duration: 3500,
                    delayTick: 1500);
                context.SetNpcEmotionLoop(arg1: 5531, arg2: "Attack_Idle_A", arg3: 7000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State첫번째전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째전투 : TriggerState {
            internal State첫번째전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {5523, 5524, 5525, 5526, 5527, 5528, 5529, 5530, 5531});
                context.CreateMonster(arg1: new int[] {523, 524, 525, 526, 527, 528, 529, 530, 531}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {523, 524, 525, 526, 527, 528, 529, 530, 531})) {
                    context.State = new State다음으로이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다음으로이동 : TriggerState {
            internal State다음으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003146}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {523, 524, 525, 526, 527, 528, 529, 530, 531});
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__4$", duration: 3500);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "706", arg2: 0)) {
                    context.State = new State너무많아(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State너무많아 : TriggerState {
            internal State너무많아(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003146}, arg2: 0)) {
                    context.State = new State머리를쓰자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머리를쓰자 : TriggerState {
            internal State머리를쓰자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__5$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State바닥을보여주자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥을보여주자 : TriggerState {
            internal State바닥을보여주자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {802}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__6$", arg3: new int[] {5000});
                context.SetInteractObject(arg1: new int[] {10003136}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003136}, arg2: 0)) {
                    context.State = new State타이밍맞추기1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이밍맞추기1 : TriggerState {
            internal State타이밍맞추기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4000}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10003136}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "709", arg2: 0)) {
                    context.State = new State머리를쓰자2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머리를쓰자2 : TriggerState {
            internal State머리를쓰자2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 5532, msg: "$02000535_BF__MAIN__7$", duration: 3500,
                    delayTick: 300);
                context.AddBalloonTalk(spawnPointID: 5501, msg: "$02000535_BF__MAIN__8$", duration: 3500,
                    delayTick: 800);
                context.AddBalloonTalk(spawnPointID: 5502, msg: "$02000535_BF__MAIN__9$", duration: 3500,
                    delayTick: 800);
                context.AddBalloonTalk(spawnPointID: 5503, msg: "$02000535_BF__MAIN__10$", duration: 3500,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 5504, msg: "$02000535_BF__MAIN__11$", duration: 3500,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 5505, msg: "$02000535_BF__MAIN__12$", duration: 3500,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 5522, msg: "$02000535_BF__MAIN__13$", duration: 3500,
                    delayTick: 300);
                context.AddBalloonTalk(spawnPointID: 5520, msg: "$02000535_BF__MAIN__14$", duration: 3500,
                    delayTick: 300);
                context.AddBalloonTalk(spawnPointID: 5521, msg: "$02000535_BF__MAIN__15$", duration: 3500,
                    delayTick: 1500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State통로이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통로이동1 : TriggerState {
            internal State통로이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 5520, msg: "$02000535_BF__MAIN__16$", duration: 5500,
                    delayTick: 4500);
                context.AddBalloonTalk(spawnPointID: 5522, msg: "$02000535_BF__MAIN__17$", duration: 5500,
                    delayTick: 7500);
                context.AddBalloonTalk(spawnPointID: 5505, msg: "$02000535_BF__MAIN__18$", duration: 5500,
                    delayTick: 8500);
                context.AddBalloonTalk(spawnPointID: 5522, msg: "$02000535_BF__MAIN__19$", duration: 5500,
                    delayTick: 12500);
                context.CreateMonster(arg1: new int[] {5000, 5001, 5002, 5003, 5004}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702", arg2: 0)) {
                    context.State = new State메이드대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메이드대사 : TriggerState {
            internal State메이드대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 670, msg: "$02000535_BF__MAIN__20$", duration: 3500,
                    delayTick: 1500);
                context.AddBalloonTalk(spawnPointID: 671, msg: "$02000535_BF__MAIN__21$", duration: 3500);
                context.SetNpcEmotionLoop(arg1: 670, arg2: "Attack_Idle_A", arg3: 5000f);
                context.SetNpcEmotionLoop(arg1: 671, arg2: "Attack_Idle_A", arg3: 5000f);
                context.DestroyMonster(arg1: new int[] {5000, 5001, 5002, 5003, 5004});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State흑성회스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회스폰 : TriggerState {
            internal State흑성회스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {670, 671});
                context.CreateMonster(arg1: new int[] {601, 602, 603, 604, 605}, arg2: true);
                context.CreateMonster(arg1: new int[] {680, 681}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 604, msg: "$02000535_BF__MAIN__22$", duration: 3500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 602, msg: "$02000535_BF__MAIN__23$", duration: 3500,
                    delayTick: 1500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601, 602, 603, 604, 605, 680, 681})) {
                    context.State = new State간부들엿보기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State간부들엿보기 : TriggerState {
            internal State간부들엿보기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "705", arg2: 0)) {
                    context.State = new State간부들엿보기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State간부들엿보기2 : TriggerState {
            internal State간부들엿보기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__24$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State간부들대화2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State간부들대화2 : TriggerState {
            internal State간부들대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "카메라리셋시키기2", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {2005}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 9902, msg: "$02000535_BF__MAIN__25$", duration: 3500);
                context.AddBalloonTalk(spawnPointID: 9903, msg: "$02000535_BF__MAIN__26$", duration: 3500,
                    delayTick: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라리셋시키기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋시키기2 : TriggerState {
            internal State카메라리셋시키기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.LockMyPc(isLock: false);
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__27$", arg3: new int[] {5000});
                context.SetEffect(arg1: new int[] {801}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10003137}, arg2: 1);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__28$", duration: 3500);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003137}, arg2: 0)) {
                    context.State = new State통로오픈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통로오픈 : TriggerState {
            internal State통로오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4001}, arg2: false);
                context.SideNpcTalk(npcID: 11004659, illust: "BreedMin_normal", duration: 4000,
                    script: "$02000535_BF__MAIN__29$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State통로오픈2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통로오픈2 : TriggerState {
            internal State통로오픈2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004659, illust: "BreedMin_normal", duration: 4000,
                    script: "$02000535_BF__MAIN__30$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "708", arg2: 0)) {
                    context.State = new State테라스몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State테라스몬스터생성 : TriggerState {
            internal State테라스몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {606, 6606, 608, 6608}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 606, msg: "$02000535_BF__MAIN__31$", duration: 5500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 608, msg: "$02000535_BF__MAIN__32$", duration: 5500,
                    delayTick: 1500);
                context.SideNpcTalk(npcID: 11004660, illust: "Armand_normal", duration: 4000,
                    script: "$02000535_BF__MAIN__33$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State테라스몬스터생성2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State테라스몬스터생성2 : TriggerState {
            internal State테라스몬스터생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004661, illust: "Kyle_normal", duration: 4000,
                    script: "$02000535_BF__MAIN__34$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "704", arg2: 0)) {
                    context.State = new State테라스몬스터생성3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State테라스몬스터생성3 : TriggerState {
            internal State테라스몬스터생성3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {607, 6607, 609, 610}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 607, msg: "$02000535_BF__MAIN__35$", duration: 5500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 610, msg: "$02000535_BF__MAIN__36$", duration: 5500,
                    delayTick: 2000);
                context.SideNpcTalk(npcID: 11004660, illust: "Armand_normal", duration: 4000,
                    script: "$02000535_BF__MAIN__37$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {606, 6606, 608, 6608, 607, 6607, 609, 610})) {
                    context.State = new State포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈생성 : TriggerState {
            internal State포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__38$", arg3: new int[] {5000});
                context.SetMesh(arg1: new int[] {4019}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10003145}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003145}, arg2: 0)) {
                    context.State = new State보안게임시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보안게임시작 : TriggerState {
            internal State보안게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameLogicEnd", value: 999);
                context.WidgetAction(arg1: "Round", arg2: "InitWidgetRound");
                context.SetUserValue(triggerID: 9002, key: "GameLogicStart", value: 999);
                context.LockMyPc(isLock: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State문열기시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기시작2 : TriggerState {
            internal State문열기시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__39$", arg3: new int[] {4000});
                context.LockMyPc(isLock: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetUserValue(triggerID: 9002, key: "GameLogicStart", value: 1);
                    context.State = new State게임로직종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료대기 : TriggerState {
            internal State게임로직종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "GameLogicEnd", value: 1)) {
                    context.State = new State게임로직종료및성공(context);
                    return;
                }

                if (context.UserValue(key: "GameLogicEnd", value: 2)) {
                    context.State = new State게임로직종료및실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및성공 : TriggerState {
            internal State게임로직종료및성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State게임로직종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및실패 : TriggerState {
            internal State게임로직종료및실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State실패게임로직종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료 : TriggerState {
            internal State게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 3000f);
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__40$", arg3: new int[] {3000});
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동하자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패게임로직종료 : TriggerState {
            internal State실패게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 3000f);
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__41$", arg3: new int[] {3000});
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__42$", duration: 3500);
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State문부시기안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문부시기안내 : TriggerState {
            internal State문부시기안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000535_BF__MAIN__43$", arg3: new int[] {5000});
                context.LockMyPc(isLock: false);
                context.CreateMonster(arg1: new int[] {611}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {611})) {
                    context.State = new State이동하자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동하자 : TriggerState {
            internal State이동하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.LockMyPc(isLock: false);
                context.SideNpcTalk(npcID: 23300001, illust: "Haren_smile", duration: 4000,
                    script: "$02000535_BF__MAIN__44$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동하자2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동하자2 : TriggerState {
            internal State이동하자2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000535_BF__MAIN__45$", duration: 3500);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}